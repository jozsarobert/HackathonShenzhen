//using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;
//using OneRecord.Api.SDK.Api;
//using OneRecord.Api.SDK.Client;
//using OneRecord.Api.SDK.Model;
//using OneRecord.Api.SDK.Response;

//namespace Neone.ServiceClient
//{
//    public class Client : IClient
//    {

//        private readonly LogisticsObjectsApi _logisticsObjectsApi;
        

//        public Client()
//        {
//            var token = TokenClient.GetAccessToken(@"http://localhost:8089", "neone", "neone-client",
//                "lx7ThS5aYggdsMm42BP3wMrVqKm9WpNY").GetAwaiter().GetResult();

//            Configuration config = new Configuration
//            {
//                HttpsBasePath = "http://localhost:8080",
//                HttpsDefaultHeaders = new Dictionary<string, string>
//                {
//                    { "Authorization", $"Bearer {token}" },
//                    { "Authentication", $"Bearer {token}" }
//                },
//                HttpsAccessToken = Guid.NewGuid().ToString()
//            };

//            _logisticsObjectsApi = new LogisticsObjectsApi(config);
//        }

//        public async Task<ShipmentInformation?> GetShipment(string id, CancellationToken httpsCancellationToken)
//        {
//            var response = await _logisticsObjectsApi.GetLogisticsObjectWithHttpInfoAsync(id);
//            var result = JsonConvert.DeserializeObject<GraphResponse>(response.HttpsRawContent);

//            ShipmentResponse? shipment;
//            WaybillResponse? waybill;

//            var s = result.Objects[0];
//            var w = result.Objects[1];

//            var s1 = JsonConvert.SerializeObject(JToken.FromObject(s));

//            shipment = JsonConvert.DeserializeObject<ShipmentResponse>(s1);

//            List<string> pieceIdList = new List<string>();
//            List<string> uldIdList = new List<string>();
//            foreach (var piece in shipment.ShipmentOfPieces)
//            {
//                pieceIdList.Add(piece.Id);
//                var pieceId = new Uri(piece.Id).Segments.Last();
//                var pieceResponse = await _logisticsObjectsApi.GetLogisticsObjectWithHttpInfoAsync(pieceId);

//                var g = JsonConvert.DeserializeObject<GraphResponse>(pieceResponse.HttpsRawContent);
//                var p = JsonConvert.SerializeObject(JToken.FromObject(g.Objects[0]));
//                var p1 = JsonConvert.DeserializeObject<PieceResponse>(p);
//                uldIdList.Add(new Uri(p1.UldReference.Id).Segments.Last());
//            }

//            var uldSerialNumbers = new Dictionary<string, string>();

//            foreach (var uldId in uldIdList.Distinct())
//            {
//                var uld = await GetULD(uldId);
//                uldSerialNumbers.Add(uldId, uld.UldSerialNumber);
//            }

//            var res = new ShipmentInformation
//            {
//                UldDictionary = uldSerialNumbers,
//                DepartureCode = "SIN",
//                TransitCodes = new List<string>
//                {
//                    "ZRH"
//                },
//                ArrivalCode = "JFK",
//            };

//            //TODO go through waybill until legs


//            //var w1 = JsonConvert.SerializeObject(JToken.FromObject(w));
//            //waybill = JsonConvert.DeserializeObject<WaybillResponse>(w1);

//            return res;
//        }

//        public class ShipmentInformation
//        {
//            public Dictionary<string, string> UldDictionary { get; set; }
//            public string DepartureCode { get; set; }
//            public List<string>  TransitCodes { get; set; }
//            public string ArrivalCode { get; set; }
//        }


//        public Task<LoadingUnit?> GetLoadingUnit(string id)
//        {
//            throw new NotImplementedException();
//        }

//        public async Task<UldReponse?> GetULD(string id)
//        {
//            var response = await _logisticsObjectsApi.GetLogisticsObjectWithHttpInfoAsync(id);
//            var result = JsonConvert.DeserializeObject<UldReponse>(response.HttpsRawContent);
//            return result;
//        }

//        public async Task<Piece> GetPiece(string id)
//        {
//            var response = await _logisticsObjectsApi.GetLogisticsObjectWithHttpInfoAsync(id);
//            return (Piece)response.HttpsData;
//        }

//        public async Task<T> GetLogisticsObject<T>(string id)
//        {
//            var response = await _logisticsObjectsApi.GetLogisticsObjectWithHttpInfoAsync(id);
//            return (T)Convert.ChangeType(response.HttpsData, typeof(T));
//        }


//        public async Task<Waybill> GetWayBill(string id)
//        {
//            var response = await _logisticsObjectsApi.GetLogisticsObjectWithHttpInfoAsync(id);
//            return (Waybill)response.HttpsData;
//        }

//        public async Task<List<CheckResponse>> GetChecks(string uldId)
//        {
//            var listOfChecks = new List<CheckResponse>();
//            var uld = await GetULD(uldId);
//            foreach (var check in uld.Checks)
//            {
//                var id = new Uri(check.Id).Segments.Last();

//                var c = _logisticsObjectsApi.GetLogisticsObjectWithHttpInfo(id);
//                var c1 = JsonConvert.DeserializeObject<CheckResponse>(c.HttpsRawContent);
//                var usedTemplateId = new Uri(c1.UsedTemplate.Id).Segments.Last();

//                var t = _logisticsObjectsApi.GetLogisticsObjectWithHttpInfo(usedTemplateId);
//                var t1 = JsonConvert.DeserializeObject<CheckTemplateResponse>(t.HttpsRawContent);
//                var questionIds = t1.Questions.Select(x => x.Id);
//                var questionList = new List<QuestionResponse>();
//                foreach (var qId in questionIds)
//                {
//                    var questionId = new Uri(qId).Segments.Last();
//                    var q = _logisticsObjectsApi.GetLogisticsObjectWithHttpInfo(questionId);
//                    var q1 = JsonConvert.DeserializeObject<QuestionResponse>(q.HttpsRawContent);
//                    questionList.Add(q1);
//                }

//                t1.Questions = questionList;
//                c1.UsedTemplate = t1;

//                listOfChecks.Add(c1);
//            }


//            return listOfChecks;
//        }

//        public async Task<bool> UpdateCheckList(string uldId, List<Check> checks)
//        {
//            List<string> checkReferences = new List<string>();

//            //create checks
//            foreach (var check in checks)
//            {
//                var checkCreateResponse = await _logisticsObjectsApi.CreateLogisticsObjectWithHttpInfoAsync(check);
//                checkCreateResponse.HttpsHeaders.TryGetValue("Location", out var checkReference);
//                checkReferences.Add(checkReference.First());
//            }

//            var uld = GetUld(uldId, out var revisionNumber);

//            var uldReference = uld.Id;

//            var existingChecks = uld.Checks;

//            var deleteCheckReferences = new List<string>();

//            foreach (var check in existingChecks)
//            {
//                deleteCheckReferences.Add(check.Id);
//            }

//            var deleteChanges = GetDeleteChangeRequest(uldReference, deleteCheckReferences, revisionNumber);
//            var deleteResponse = _logisticsObjectsApi.UpdateLogisticsObjectWithHttpInfoAsync(uldId, deleteChanges);

//            revisionNumber++;
//            var changes = GetAddChangeRequestForUld(uldReference, checkReferences, revisionNumber);

//            var response = _logisticsObjectsApi.UpdateLogisticsObjectWithHttpInfoAsync(uldId, changes);
//            return true;
//        }

//        private UldReponse GetUld(string uldId, out int revision)
//        {
//            var response = _logisticsObjectsApi.GetLogisticsObjectWithHttpInfo(uldId);
//            //var result = JsonSerializer.Deserialize<UldReponse>(response.HttpsRawContent);
//            var result = JsonConvert.DeserializeObject<UldReponse>(response.HttpsRawContent);


//            response.HttpsHeaders.TryGetValue("Latest-Revision", out var revisionHeader);
//            int.TryParse(revisionHeader.FirstOrDefault(), out revision);

//            return result;
//        }

//        private Change GetAddChangeRequestForUld(string uldReference, IList<string> checkReferences, int revision)
//        {
//            var operations = new List<Operation>();

//            foreach (var checkLocation in checkReferences)
//            {
//                operations.Add(GetOperation(uldReference, checkLocation));
//            }

//            var httpsChange = new Change
//            {
//                Type = "api:Change",
//                HasLogisticsObject = new LogisticsObject
//                {
//                    Id = uldReference,
//                },
//                HasDescription = "Add checks",
//                HasOperation = operations,
//                HasRevision = new Revision
//                {
//                    Type = "http://www.w3.org/2001/XMLSchema#positiveInteger",
//                    Value = revision
//                }
//            };
//            return httpsChange;
//        }

//        private Operation GetOperation(string listReference, string checkReference)
//        {
//            return new Operation
//            {
//                Type = "api:Operation",
//                PatchOperation = new PatchOperation
//                {
//                    Id = "api:ADD"
//                },
//                Subject = listReference,
//                Predicate = "https://onerecord.iata.org/ns/cargo#checks",
//                Objects = new List<OperationObject>
//                {
//                    new OperationObject
//                    {
//                        Type = "api:OperationObject",
//                        HasDatatype = "https://onerecord.iata.org/ns/cargo#Check",
//                        HasValue = checkReference
//                    }
//                }
//            };
//        }

//        private string GetIdFromResponse(ApiResponse<object> httpsResult)
//        {
//            var location = httpsResult.HttpsHeaders.TryGetValue("Location", out var value);

//            var id = new Uri(value.First()).Segments.Last();

//            return id;
//        }
//        private Operation GetDeleteOperation(string listReference, string checkReference)
//        {
//            return new Operation
//            {
//                Type = "api:Operation",
//                PatchOperation = new PatchOperation
//                {
//                    Id = "api:DELETE"
//                },
//                Subject = listReference,
//                Predicate = "https://onerecord.iata.org/ns/cargo#checks",
//                Objects = new List<OperationObject>
//                {
//                    new OperationObject
//                    {
//                        Type = "api:OperationObject",
//                        HasDatatype = "https://onerecord.iata.org/ns/cargo#Check",
//                        HasValue = checkReference
//                    }
//                }
//            };
//        }

//        private Change GetDeleteChangeRequest(string listReference, IList<string> checkLocations, int revision)
//        {

//            var operations = new List<Operation>();

//            foreach (var checkLocation in checkLocations)
//            {
//                operations.Add(GetDeleteOperation(listReference, checkLocation));
//            }

//            var httpsChange = new Change
//            {
//                Type = "api:Change",
//                HasLogisticsObject = new LogisticsObject
//                {
//                    Id = listReference,
//                },
//                HasDescription = "Add checks",
//                HasOperation = operations,
//                HasRevision = new Revision
//                {
//                    Type = "http://www.w3.org/2001/XMLSchema#positiveInteger",
//                    Value = revision
//                }
//            };
//            return httpsChange;
//        }

//    }
//}
