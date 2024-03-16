using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracking.Data.DomainModel;

namespace Tracking.Data.Repositories
{
    public class PieceRepository : IPieceRepository
    {
        private readonly TrackingDbContext _dbContext;

        public PieceRepository(TrackingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public PieceModel GetPieceById(int id)
        {
            var result = _dbContext.Piece.Where(x => x.Id == id).Select(x => new PieceModel
            {

            }).FirstOrDefault();

            return result;
        }

        public List<PieceModel> GetPieces()
        {
            var result = _dbContext.Piece.Select(x => new PieceModel { }).ToList();
            return result;
        }

        public async Task UpdateSensorData(int id, string serialNumber, double? temperature, double? elevation, double? latitude, double? longitude, DateTime timeStamp)
        {
            var iotDevices = _dbContext.Piece.Where(x => x.Id == id).FirstOrDefault().AttachedIotDevices;

            var iotDevice = iotDevices.Where(x => x.SerialNumber == serialNumber).FirstOrDefault();
            var thermometer = iotDevice.ConnectedSensors.Where(x => x.Type.Contains("THERMOMETER")).FirstOrDefault();
            var geoLocator = iotDevice.ConnectedSensors.Where(x => x.Type.Contains("GEOLOCATION")).FirstOrDefault();
            

            if (temperature != null && thermometer != null)
            {

                thermometer.Measurements.Add(new OneRecord.Data.Model.Model.Measurement
                {
                    MeasurementValue = new OneRecord.Data.Model.Model.Value
                    {
                        NumericalValue = temperature.Value,
                        Unit = "Celsius",
                    },
                    MeasurementTimestamp = timeStamp,
                });
            }
            if (latitude.HasValue && longitude.HasValue && geoLocator != null)
            {

                var measurement = new OneRecord.Data.Model.Model.Measurement
                {
                    RecordedGeolocation = new OneRecord.Data.Model.Model.Geolocation
                    {
                        Latitude = latitude.Value,
                        Longitude = longitude.Value,
                        Elevation = elevation.HasValue ? new OneRecord.Data.Model.Model.Value
                        {
                            Unit = "METER",
                            NumericalValue = elevation.Value
                        } : null
                    }
                };
                if (geoLocator.Id != thermometer.Id)
                {
                    geoLocator.Measurements.Add(measurement);
                }
                else
                {
                    thermometer.Measurements.Add(measurement);
                }
            }

            _dbContext.Update(iotDevice);

            await _dbContext.SaveChangesAsync();

        }
    }
}
