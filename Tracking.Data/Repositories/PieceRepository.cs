﻿using Microsoft.EntityFrameworkCore;
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
            var result = _dbContext.Piece
                .Include(x => x.GrossWeight)
                .Include(x => x.TemperatureInstructions)
                .Include(x => x.Dimensions).ThenInclude(x => x.Volume)
                .Where(x => x.Id == id).Select(x => new PieceModel
                {
                    Id = x.Id,
                    Weight = new Weight
                    {
                        Unit = x.GrossWeight.Unit,
                        Value = x.GrossWeight.NumericalValue
                    },
                    Volume = new Volume
                    {
                        Value = x.Dimensions.Volume.NumericalValue,
                        Unit = x.Dimensions.Volume.Unit
                    },
                    IsTemperatureControlled = x.TemperatureInstructions != null,
                    MinTemperature = x.TemperatureInstructions.MinTemperature.NumericalValue,
                    MaxTemperature = x.TemperatureInstructions.MaxTemperature.NumericalValue,

                }).FirstOrDefault();

            var movementId = _dbContext.Loading
                .Include(x => x.LoadedPieces)
                .Include(x => x.ServedActivity)
                .Where(x => x.LoadedPieces.Select(x => x.Id).Contains(id))
                .Where(x => x.LoadingType == "LOADING")
                .Select(x => x.ServedActivity.Id)
                .FirstOrDefault();

            var flight = _dbContext.TransportMovement.Where(x => x.Id == movementId)
                .Include(x => x.ArrivalLocation)
                .Include(x => x.DepartureLocation)
                .Include(x => x.MovementTimes)
                .Select(x => new FlightModel
                {
                    OriginCode = x.DepartureLocation.Code,
                    DestinationlCode = x.ArrivalLocation.Code,
                    FlightNo = x.TransportIdentifier,
                    DepartureDateTime = x.MovementTimes.Where(y => y.Direction == "OUTBOUND").FirstOrDefault().MovementTimestamp,
                    ArrivalDateTime = x.MovementTimes.Where(y => y.Direction == "INBOUND").FirstOrDefault().MovementTimestamp,

                }).FirstOrDefault();

            var sensorThermoData = _dbContext.Piece.Where(x => x.Id == id)
                .Include(x => x.AttachedIotDevices).ThenInclude(x => x.ConnectedSensors).ThenInclude(x => x.Measurements)
                .Select(x => x.AttachedIotDevices.FirstOrDefault().ConnectedSensors.Where(z => z.SensorType == "THERMOMETER").FirstOrDefault().Measurements
                ).ToList().SelectMany(x=> x).ToList();

            var sensorLocationData = _dbContext.Piece.Where(x => x.Id == id)
                .Include(x => x.AttachedIotDevices).ThenInclude(x => x.ConnectedSensors).ThenInclude(x => x.Measurements)
                .Select(x => x.AttachedIotDevices.FirstOrDefault().ConnectedSensors.Where(z => z.SensorType == "GEOLOCATION").FirstOrDefault().Measurements
                ).ToList().SelectMany(x => x).ToList();

            var currentTemperature = sensorThermoData.OrderByDescending(x => x.MeasurementTimestamp).FirstOrDefault()?.MeasurementValue;

            result.CurrentTemperature = currentTemperature?.NumericalValue;
            result.TemperatureHistory = sensorThermoData.Select(x => new MeasuredTemperature
            {
                Timestamp = x.MeasurementTimestamp,
                Unit = x.MeasurementValue.Unit,
                Value = x.MeasurementValue.NumericalValue
            }).ToList();
            result.AlertType = GetAlert(id, sensorThermoData, result.MinTemperature, result.MaxTemperature);
            result.Flight = flight;
            return result;
        }

        private string GetAlert(int id, List<OneRecord.Data.Model.Model.Measurement> sensorThermoData, double? minTemperature, double? maxTemperature)
        {
            var thermoAlert = sensorThermoData?.Any(x => x.MeasurementValue.NumericalValue < minTemperature || x.MeasurementValue.NumericalValue > maxTemperature) ?? false;
            if (thermoAlert) 
            {
                return "THERMOMETER";
            }

            return null;
        }

        public async Task UpdateSensorData(int id, string serialNumber, double? temperature, double? elevation, double? latitude, double? longitude, DateTime timeStamp)
        {
            var iotDevices = _dbContext.Piece
                .Include(x=> x.AttachedIotDevices).ThenInclude(x=>x.ConnectedSensors).ThenInclude(x=>x.Measurements)
                .Where(x => x.Id == id).FirstOrDefault().AttachedIotDevices;

            var iotDevice = iotDevices.Where(x => x.SerialNumber == serialNumber).FirstOrDefault();
            var thermometer = iotDevice.ConnectedSensors.Where(x => x.SensorType.Contains("THERMOMETER")).FirstOrDefault();
            var geoLocator = iotDevice.ConnectedSensors.Where(x => x.SensorType.Contains("GEOLOCATION")).FirstOrDefault();


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

            _dbContext.Update(thermometer);

            await _dbContext.SaveChangesAsync();

        }

        public List<PieceModel> GetPieceByShipmentId(int id)
        {
            var pieceIds = _dbContext.Shipment.Include(x => x.Pieces)
                .SelectMany(x => x.Pieces.Select(y => y.Id)).ToList();

            var pieces = new List<PieceModel>();

            foreach (var pieceId in pieceIds)
            {
                pieces.Add(GetPieceById(pieceId));
            }

            return pieces;
        }
    }
}
