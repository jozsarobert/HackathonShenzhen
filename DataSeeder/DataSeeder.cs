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


            var activitySequence = GetActivitySequence();
            var loading = GetLoading();
            var shipment = GetShipment("721-1234568", "LX14", new DateTime(2024, 3, 16, 13, 10, 0), new DateTime(2024, 3, 16, 18, 20, 0), "ZHR", "JFK", 50, ["COL"], "THERMOMETER", "0000007B", 200,
                               new List<OneRecord.Data.Model.Model.Piece> { GetPiece(GetDimensions(0.3, "MC"),GetValue(50.0, "Kg"), ["",""],"goodDescription","ID112"),
                                                 GetPiece(GetDimensions(0.8, "MC"),GetValue(150.0, "Kg"), ["",""],"goodDescription","ID223")
                                               },
                               "chocolate", 8, 2);

            dbContext.Shipment.Add(shipment);
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
        private Booking GetBooking()
        {
            var result = new Booking
            {
                ActivitySequences = new List<ActivitySequence>()
                //IssuedForWaybill = new Waybill(),
                //BookingStatus = "",
                //WaybillPrefix = "",
                //WaybillNumber = ""
            };

            return result;

        }
        private Context GetContext()
        {
            var result = new Context
            {
                Cargo = "Cargo",
                Api = "Api",
                Vocab = "Vocab"
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
        private Geolocation GetGeolocation()
        {
            var result = new Geolocation
            {
                Elevation = new Value(),
                GeolocationUnit = "",
                Latitude = 0.0,
                Longitude = 0.0
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
        private Loading GetLoading()
        {
            var result = new Loading
            {
                LoadedPieces = new List<Piece>(),
                OnTransportMeans = new TransportMeans(),
                LoadingPositionIdentifier = "",
                LoadingType = ""
            };

            return result;

        }
        private Location GetLocation()
        {
            var result = new Location
            {
                ForActions = new List<LogisticsAction>(),
                Geolocation = new Geolocation(),
                Code = "",
                LocationName = "",
                LocationType = "",
            };

            return result;

        }
        private LogisticsAction GetLogisticsAction()
        {
            var result = new LogisticsAction
            {
                ServedActivity = new LogisticsActivity(),
                ActionEndTime = new DateTime(),
                ActionStartTime = new DateTime(),
                ActionTimeType = ""
            };

            return result;

        }
        private LogisticsActivity GetLogisticsActivity()
        {
            var result = new LogisticsActivity
            {
                ServedServices = new List<LogisticsService>(),
                ExecutionStatus = ""
            };

            return result;

        }
        private LogisticsAgent GetLogisticsAgent()
        {
            var result = new LogisticsAgent();

            return result;

        }
        private LogisticsObject GetLogisticsObject()
        {
            var result = new LogisticsObject
            {
                CompanyIdentifier = "",
                SkeletonIndicator = false
            };

            return result;

        }
        private LogisticsService GetLogisticsService()
        {
            var result = new Booking
            {
                ActivitySequences = new List<ActivitySequence>()
            };

            return result;

        }
        private Measurement GetMeasurement()
        {
            var result = new Measurement
            {
                MeasurementValue = new Value(),
                RecordedGeolocation = new Geolocation(),
                MeasurementTimestamp = new DateTime()
            };

            return result;

        }
        private MovementTimes GetMovementTimes()
        {
            var result = new MovementTimes
            {
                Direction = "",
                MovementMilestone = "",
                MovementTimeType = "",
                MovementTimestamp = new DateTime(),
            };

            return result;

        }
        private PhysicalLogisticsObject GetPhysicalLogisticsObject()
        {
            var result = new PhysicalLogisticsObject
            {
                AttachedIotDevices = new List<IotDevice>(),
                InvolvedInActions = new List<LogisticsAction>()
            };

            return result;

        }
        private Piece GetPiece(Dimensions dimensions, Value grossWeight, List<string> specialHandlingCodes, string goodDescription, string iotSerialnumber)
        {
            var result = new Piece
            {
                //ContainedPieces = new List<Piece> (),
                //ContentProductionCountry = "",
                Dimensions = dimensions,
                GrossWeight = grossWeight,
                //OfShipment = new Shipment(),
                //LoadType = "",
                //FulfillsUldTypeCode = "",
                //PackageMarkCoded = "",
                SpecialHandlingCodes = specialHandlingCodes,
                Coload = false,
                GoodsDescription = goodDescription,
                //NvdForCarriage = false,
                //NvdForCustoms = false,
                //PackagedeIdentifier = "",
                //ShippingMarks = new List<string>(),
                //Slac = 0,
                //Stackable = false,
                //TextualHandlingInstructions = new List<string>(),
                //Turnable = false,
                //Upid = ""
                AttachedIotDevices = GetIotDevice(iotSerialnumber)
            };

            return result;

        }
        private Sensor GetSensor(string sensorType)
        {
            var result = new Sensor
            {
                Measurements = new List<Measurement>(),
                //PartOfIotDevice = new IotDevice(),
                //Description = "",
                //Name = "",
                SensorType = sensorType,
                //SerialNumber = ""
            };

            return result;

        }
        public Shipment GetShipment(string waybillNumber,
                                   string flightNo,
                                   DateTime departureDate,
                                   DateTime arrivalDate,
                                   string departureCode,
                                   string arrivalCode,
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
                    Activity = GetTransportMovement(arrivalCode,departureCode,flightNo, departureDate,arrivalDate)
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
        private TransportMeans GetTransportMeans()
        {
            var result = new TransportMeans
            {
                OperatedTransportMovements = new List<TransportMovement>(),
                VehicleModel = "",
                VehicleRegistration = "",
                VehicleSize = "",
                VehicleType = ""
            };

            return result;

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
                //Dimensions = new Dimensions(),
                //DimensionId = ""
            };

            return result;

        }
        private Waybill GetWaybill()
        {
            var result = new Waybill
            {
                ArrivalLocation = new Location(),
                ReferredBookingOption = new Booking(),
                DepartureLocation = new Location(),
                Shipment = new Shipment(),
                WaybillType = "",
                CarrierChargeCode = "",
                OtherChargesIndicator = "",
                ServiceCode = "",
                WeightValueIndicator = "",
                CustomsOriginCode = "",
                AccountingInformation = "",
                CarrierDeclarationDate = new DateTime(),
                CarrierDeclarationSignature = "",
                ConsignorDeclarationSignature = "",
                DestinationCurrencyRate = 0.0,
                ShippingInfo = "",
                ShippingRefNo = "",
                WaybillNumber = "",
                WaybillPrefix = "",
                ModularCheckNumber = false,
            };

            return result;

        }
    }
}