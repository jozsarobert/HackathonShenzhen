#pragma warning disable VSSpell001 // Spell Check

using Microsoft.EntityFrameworkCore;
using OneRecord.Data.Model.Model;
using System.ComponentModel.DataAnnotations;
using Tracking.Data;

namespace DataSeeder
{
    public class DataSeeder
    {
        #region "Shipment 1"
        // Shipment 1 (temp deviation case): ID 724-1234568 (ZRH-JFK) – total 2 pieces, weight 200 KG, volume 1.1MC
        // 
        // Piece 1: ID111 with IOT device ID112 (050kg, 0.3 MC)
        // Piece 2: ID222 with IOT device ID223 (150kg, 0.8 MC)
        // 
        // The nature of the shipment is chocolate, and it requires temperature-controlled storage. 
        // It is booked with special handling code COL (temperature 2-8 degrees).
        //
        // Shipment is booked on LX14/16MAR with ETD 1310.
        // 
        #endregion

        #region "Shipment 2"
        // Shipment 2 (location deviation case): ID 724-87654321 (ZRH-JFK) – total 2 pieces, weight 400 KG, volume 2.2MC
        // 
        // Piece 1: ID333 with IOT device ID334 (100kg, 0.6 MC)
        // Piece 2: ID444 with IOT device ID445 (300kg, 1.6 MC)
        // 
        // The nature of the shipment is electronics (eCommerce).
        // 
        // Piece 1 is booked on LX14/16MAR with ETD 1310.
        // Piece 2 is booked on LX14/17MAR with ETD 1310
        // 
        #endregion

        #region "Shipment 3"
        // Other random shipment numbers to be used and displayed in the dashboard with itinerary, piece and weight info.
        // 
        // 724-24681346: SIN-JFK – 1 piece,            weight 150  kg, 0.8MC, general  cargo
        // 724-59871236: NRT-JFK – CONSOL – 10 pieces, weight 1500 kg  4.0MC, general  cargo
        // 724-78459613: FCO-JFK – 3 pieces,           weight 50   kg, 0.4MC, valuable cargo
        // 724-74125896: MAD-JFK – 2 pieces,           weight 180  kg, 1.0MC, pharmacy
        #endregion

        public DataSeeder()
        {
            var options = new DbContextOptionsBuilder<TrackingDbContext>()
                .UseSqlServer("server=localhost,1434;database=TrackingDb;User ID=sa;password=Shenzhen2024!;TrustServerCertificate=true;").Options;

            var dbContext = new TrackingDbContext(options);

            CreateShipment1(dbContext);
            CreateShipment2(dbContext);

        }

        private void CreateShipment1(TrackingDbContext dbContext)
        {
            var pieces = new List<Piece> { GetPiece(GetDimensions(0.3, "MC"),GetValue(50.0, "Kg"), ["COL"],"goodDescription","ID112", 2, 8),
                                           GetPiece(GetDimensions(0.1, "MC"),GetValue(150.0, "Kg"), ["COL"],"goodDescription","ID223", 2,8),
                                            GetPiece(GetDimensions(0.2, "MC"),GetValue(30.0, "Kg"), null,"goodDescription","ID1123", null, null),
                                           GetPiece(GetDimensions(0.4, "MC"),GetValue(15.0, "Kg"), ["COL"],"goodDescription","ID224", 2,8),
                                            GetPiece(GetDimensions(0.2, "MC"),GetValue(5.0, "Kg"), null,"goodDescription","ID114", null, null),
                                           GetPiece(GetDimensions(0.4, "MC"),GetValue(120.0, "Kg"), ["COL"],"goodDescription","ID225", 2,8),

            };

            var flightInfoList = new List<FlightInfo>();
            var fligthInfo = new FlightInfo
            {
                FlightNo = "LX14",
                DepartureDate = new DateTime(2024, 3, 17, 9, 50, 0),
                ArrivalDate = new DateTime(2024, 3, 17, 14, 0, 0),
                DepartureCode = "ZHR",
                ArrivalCode = "JFK"
            };
            var fligthInfo2 = new FlightInfo
            {
                FlightNo = "LX16",
                DepartureDate = new DateTime(2024, 3, 17, 13, 10, 0),
                ArrivalDate = new DateTime(2024, 3, 17, 17, 30, 0),
                DepartureCode = "ZHR",
                ArrivalCode = "JFK"
            };

            flightInfoList.Add(fligthInfo);
            flightInfoList.Add(fligthInfo2);

            var specialHandlingCodes = pieces.Where(x=>x.SpecialHandlingCodes != null).SelectMany(x => x.SpecialHandlingCodes).Distinct().ToList();
            var totalWeight = pieces.Select(x => x.GrossWeight.NumericalValue).Sum();

            var shipment = GetShipment("721-4567234", flightInfoList, specialHandlingCodes, totalWeight, pieces, "chocolate");

            dbContext.Shipment.Add(shipment);
            dbContext.SaveChanges();

            var activitySequences = shipment.Waybill.ReferredBookingOption.ActivitySequences;

            if (activitySequences.Count == 1)
            {
                var activitySequence = shipment.Waybill.ReferredBookingOption.ActivitySequences.First();
                var loading = GetLoading(activitySequence.Activity, pieces);

                dbContext.Loading.Add(loading);
            }
            else
            {
                var count = activitySequences.Count;

                List<List<Piece>> picesLists = GetPicecesList(pieces, count);

                foreach (var item in activitySequences)
                {
                    var loading = GetLoading(item.Activity, pieces);

                    dbContext.Loading.Add(loading);
                }
            }

            dbContext.SaveChanges();
        }

        private void CreateShipment2(TrackingDbContext dbContext)
        {
            var pieces = new List<Piece> { GetPiece(GetDimensions(0.3, "MC"),GetValue(50.0, "Kg"), ["COL"],"goodDescription","ID112", 2, 8),
                                           GetPiece(GetDimensions(0.1, "MC"),GetValue(150.0, "Kg"), ["COL"],"goodDescription","ID223", 2,8),


            };

            var flightInfoList = new List<FlightInfo>();
            var fligthInfo = new FlightInfo
            {
                FlightNo = "LX14",
                DepartureDate = new DateTime(2024, 3, 17, 9, 50, 0),
                ArrivalDate = new DateTime(2024, 3, 17, 14, 0, 0),
                DepartureCode = "ZHR",
                ArrivalCode = "JFK"
            };


            flightInfoList.Add(fligthInfo);

            var specialHandlingCodes = pieces.Where(x => x.SpecialHandlingCodes != null).SelectMany(x => x.SpecialHandlingCodes).Distinct().ToList();
            var totalWeight = pieces.Select(x => x.GrossWeight.NumericalValue).Sum();

            var shipment = GetShipment("721-1234568", flightInfoList, specialHandlingCodes, totalWeight, pieces, "chocolate");

            dbContext.Shipment.Add(shipment);
            dbContext.SaveChanges();

            var activitySequences = shipment.Waybill.ReferredBookingOption.ActivitySequences;

            if (activitySequences.Count == 1)
            {
                var activitySequence = shipment.Waybill.ReferredBookingOption.ActivitySequences.First();
                var loading = GetLoading(activitySequence.Activity, pieces);

                dbContext.Loading.Add(loading);
            }
            else
            {
                var count = activitySequences.Count;

                List<List<Piece>> picesLists = GetPicecesList(pieces, count);

                foreach (var item in activitySequences)
                {
                    var loading = GetLoading(item.Activity, pieces);

                    dbContext.Loading.Add(loading);
                }
            }

            dbContext.SaveChanges();
        }

        private List<List<Piece>> GetPicecesList(List<Piece> pieces, int count)
        {
            return DivideList<Piece>(pieces, count);
        }

        static List<List<T>> DivideList<T>(List<T> list, int numberOfLists)
        {
            List<List<T>> dividedLists = new List<List<T>>();

            // Calculate the number of items per each divided list
            int itemsPerList = list.Count / numberOfLists;
            int remainder = list.Count % numberOfLists;

            // Initialize starting index
            int startIndex = 0;

            // Divide the list
            for (int i = 0; i < numberOfLists; i++)
            {
                int count = itemsPerList + (i < remainder ? 1 : 0);

                List<T> sublist = list.GetRange(startIndex, count);
                dividedLists.Add(sublist);

                // Update starting index for the next sublist
                startIndex += count;
            }

            return dividedLists;
        }

        private Dimensions GetDimensions(double value, string unit)
        {
            var result = new Dimensions
            {
                Volume = new Value
                {
                    NumericalValue = value,
                    Unit = unit
                },
            };

            return result;

        }

        private List<IotDevice> GetIotDevice(string serialNumber)
        {
            return [new IotDevice
            {
                SerialNumber = serialNumber,
                DeviceModel = "Reelables smart label",
                ConnectedSensors =
                            [
                                GetSensor("THERMOMETER"),
                                GetSensor("GEOLOCATION")
                            ]
            }
            ];
        }
        private Loading GetLoading(LogisticsActivity servedActivity, List<Piece> pieces)
        {
            var result = new Loading
            {
                LoadedPieces = pieces,
                LoadingType = "LOADING",
                ServedActivity = servedActivity,
            };

            return result;

        }

        private Piece GetPiece(Dimensions dimensions, Value grossWeight, List<string> specialHandlingCodes, string goodDescription, string iotSerialnumber, double? minTemperature, double? maxTemperamenture)
        {
            var result = new Piece
            {
                Dimensions = dimensions,
                GrossWeight = grossWeight,
                SpecialHandlingCodes = specialHandlingCodes,
                Coload = false,
                GoodsDescription = goodDescription,
                AttachedIotDevices = GetIotDevice(iotSerialnumber),
            };

            if (minTemperature.HasValue || maxTemperamenture.HasValue)
            {
                result.TemperatureInstructions = new TemperatureInstructions();

                if (minTemperature.HasValue)
                {
                    result.TemperatureInstructions.MinTemperature = new Value
                    {
                        NumericalValue = minTemperature.Value,
                        Unit = "CELSIUS"
                    };
                }

                if (maxTemperamenture.HasValue)
                {
                    result.TemperatureInstructions.MaxTemperature = new Value
                    {
                        NumericalValue = maxTemperamenture.Value,
                        Unit = "CELSIUS"
                    };
                }


            }

            return result;

        }
        private Sensor GetSensor(string sensorType)
        {
            var result = new Sensor
            {
                Measurements = new List<Measurement>(),
                SensorType = sensorType,
            };

            return result;

        }
        public Shipment GetShipment(string waybillNumber,
                                  List<FlightInfo> flightInfoList,
                                   List<string> specialHandlingCodes,
                                   double totalWeight,
                                   List<Piece> pieces,
                                   string goodDescription)

        {
            var activitySequences = new List<ActivitySequence>();

            foreach (var flightInfo in flightInfoList)
            {
                var activitySequence = new ActivitySequence
                {
                    Activity = GetTransportMovement(flightInfo.ArrivalCode, flightInfo.DepartureCode, flightInfo.FlightNo, flightInfo.DepartureDate, flightInfo.ArrivalDate)
                };
                activitySequences.Add(activitySequence);
            }

            return new Shipment
            {
                Waybill = new Waybill
                {
                    WaybillNumber = waybillNumber,
                    ReferredBookingOption = new Booking
                    {
                        ActivitySequences = activitySequences,

                    }
                },
                Pieces = pieces,
                SpecialHandlingCodes = specialHandlingCodes,
                TotalGrossWeight = new Value { NumericalValue = totalWeight, Unit = "Kg" },
                TotalDimensions = new List<Dimensions>(),
                Incoterms = "",
                GoodsDescription = goodDescription,
                TextualHandlingInstructions = new List<string>()
            };

        }

        private TransportMovement GetTransportMovement(string arrivalCode, string departureCode, string flightNo, DateTime departureDateTime, DateTime arrivalDateTime)
        {
            var result = new TransportMovement
            {
                Actions = new List<LogisticsAction>(),
                ArrivalLocation = new Location
                {
                    Code = arrivalCode
                },

                DepartureLocation = new Location
                {
                    Code = departureCode
                },
                MovementTimes = new List<MovementTimes>
                {
                    new MovementTimes
                    {
                        Direction = "OUTBOUND",
                        MovementTimestamp = departureDateTime
                    },
                                       new MovementTimes
                    {
                        Direction = "INBOUND",
                        MovementTimestamp = arrivalDateTime
                    }

                },
                OperatingTransportMeans = new TransportMeans(),

                TransportIdentifier = flightNo
            };

            return result;

        }
        private Value GetValue(double value, string unit)
        {
            var result = new Value
            {
                NumericalValue = value,
                Unit = unit,
            };

            return result;

        }

        public class FlightInfo
        {
            public string FlightNo { get; set; }
            public DateTime DepartureDate { get; set; }
            public DateTime ArrivalDate { get; set; }
            public string DepartureCode { get; set; }
            public string ArrivalCode { get; set; }
        }
    }
}