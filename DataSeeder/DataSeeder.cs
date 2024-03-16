#pragma warning disable VSSpell001 // Spell Check

using Microsoft.EntityFrameworkCore;
using OneRecord.Data.Model.Model;
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

            var pieces = new List<Piece> { GetPiece(GetDimensions(0.3, "MC"),GetValue(50.0, "Kg"), ["",""],"goodDescription","ID112"),
                                           GetPiece(GetDimensions(0.8, "MC"),GetValue(150.0, "Kg"), ["",""],"goodDescription","ID223")
                                               };
            var fligthInfo = new FlightInfo
            {
                FlightNo = "LX14",
                DepartureDate = new DateTime(2024, 3, 16, 13, 10, 0),
                ArrivalDate = new DateTime(2024, 3, 16, 18, 20, 0),
                DepartureCode = "ZHR",
                ArrivalCode = "JFK"
            };

            var shipment = GetShipment("721-1234568", fligthInfo, 50, ["COL"], "THERMOMETER", "0000007B", 200,
                              pieces,
                               "chocolate", 8, 2);

            dbContext.Shipment.Add(shipment);
            dbContext.SaveChanges();

            var activitySequence = shipment.Waybill.ReferredBookingOption.ActivitySequences.First();

            var loading = GetLoading(activitySequence.Activity, pieces);

            dbContext.Loading.Add(loading);
            dbContext.SaveChanges();

        }

        private ActivitySequence GetActivitySequence()
        {
            var result = new ActivitySequence
            {
                Activity = new LogisticsActivity(),
                SequenceNumber = ""
            };

            return result;

        }
        private Dimensions GetDimensions(double value, string unit)
        {
            var result = new Dimensions
            {
                //Height = new Value(),
                //Length = new Value(),
                Volume = new Value(),
                //Width = new Value(),
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

        private Piece GetPiece(Dimensions dimensions, Value grossWeight, List<string> specialHandlingCodes, string goodDescription, string iotSerialnumber)
        {
            var result = new Piece
            {
                Dimensions = dimensions,
                GrossWeight = grossWeight,
                SpecialHandlingCodes = specialHandlingCodes,
                Coload = false,
                GoodsDescription = goodDescription,
                AttachedIotDevices = GetIotDevice(iotSerialnumber)
            };

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
                                  FlightInfo flightInfo,
                                   double weight,
                                   List<string> specialHandlingCodes,
                                   string sensorType,
                                   string serialNumber,
                                   double totalWeight,
                                   List<Piece> pieces,
                                   string goodDescription,
                                   double? maxTemperature = null,
                                   double? minTemperature = null)

        {


            var activitySequences = new List<ActivitySequence>
            {
                new ActivitySequence
                {
                    Activity = GetTransportMovement(flightInfo.ArrivalCode,flightInfo.DepartureCode,flightInfo.FlightNo, flightInfo.DepartureDate, flightInfo.ArrivalDate)
                }
            };



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
                NumericalValue = 0.0,
                Unit = "",
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