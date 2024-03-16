using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Tracking.Data.Model;

namespace Tracking.Data
{
    public class DataSeeder
    {
        public DataSeeder()
        {
            var a = GetShipment("721-1234568", "LX14",
                new DateTime(2024, 3, 16, 13, 10, 0),
                "ZHR",
                "JFK",
                50,
                new List<string> { "COL" },
                "THERMOMETER",
                "0000007B", 8, 2);
        }

        public Shipment GetShipment(string waybillNumber, string flightNo,
            DateTime departureDate, string departureCode, string arrivalCode, double weight, List<string> specialHandlingCodes,
            string sensorType, string serialNumber, double? maxTemperature = null, double? minTemperature = null)
        {
            var bookingOptionRequest = specialHandlingCodes.Contains("COL") ? new BookingOptionRequest
            {
                BookingShipmentDetails = new BookingShipment
                {
                    TemperatureInstructions = new TemperatureInstructions
                    {
                        MinTemperature = new Value { NumericalValue = minTemperature.Value, Unit = "Celsius" },
                        MaxTemperature = new Value { NumericalValue = maxTemperature.Value, Unit = "Celsius" },
                    }
                }
            } : null;

            return new Shipment
            {
                Waybill = new Waybill
                {
                    WaybillNumber = waybillNumber,
                    ReferredBookingOption = new Booking
                    {
                        BookingRequest = new BookingRequest
                        {
                            BookingOption = new BookingOption
                            {
                                ForBookingOptionRequest = bookingOptionRequest,
                                TransportLegs = new List<TransportLegs>
                                    {
                                        new TransportLegs
                                        {
                                            TransportIdentifier = flightNo,
                                            DepartureDate = departureDate,
                                            DepartureLocation = new Location
                                            {
                                                Code = departureCode },
                                            ArrivalLocation = new Location
                                            {
                                                Code = arrivalCode },
                                            LegNumber = 1
                                        }
                                    }
                            }
                        }
                    }
                },
                Pieces = new List<Piece>
                    {
                        new Piece
                        {
                            GrossWeight = new Value
                {
                    NumericalValue = weight,
                    Unit = "Kg"
                },
                SpecialHandlingCodes = specialHandlingCodes,
                AttachedIotDevices = new List<IotDevice> { new IotDevice
                {
                    DeviceModel = "Reelables smart label",
                    ConnectedSensors = new List<Sensor>
                    {
                        new Sensor
                        {
                            SensorType = sensorType,
                        }
                    },
                    SerialNumber = serialNumber } }
                        }
                    }
            };

                
            
        }

    }
}
