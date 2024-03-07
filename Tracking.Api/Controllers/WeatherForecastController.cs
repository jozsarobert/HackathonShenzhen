using Microsoft.AspNetCore.Mvc;
using Tracking.Data;

namespace Tracking.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly TrackingDbContext _dbContext;

        public WeatherForecastController(TrackingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public bool Get()
        {
            _dbContext.Piece.Add(new Data.Model.Piece
            {
                
                UldReference = new Data.Model.LoadingUnit
                {

                },
                AttachedIotDevices = new List<Data.Model.IotDevice> { 
                    new Data.Model.IotDevice
                    {
                        Name = "",

                        //ConnectedSensors = new List<Data.Model.Sensor>
                    } 
                },
                PartOfShipment = new Data.Model.Shipment
                {
                    Waybill = new Data.Model.Waybill 
                    {
                        WaybillNumber = "",
                        WaybillPrefix = "",
                        WaybillType = "",
                        ArrivalLocation = new Data.Model.Location
                        {

                        }
                        
                    },
                    
                },
                TransportOrganization = new Data.Model.Organization
                {

                },
                Coload = false,
                CompanyIdentifier = "",
                ContentProductionCountry = new Data.Model.Country
                {
                    CountryCode = "",
                    CountryName = ""
                },
                DeclaredValueForCarriage = "",
                DeclaredValueForCustoms = "",
                Dimensions = new Data.Model.Dimensions
                {
                    Height = new Data.Model.Value
                    {
                        NumericalValue = 0,
                        Unit = "",
                    },
                    Width = new Data.Model.Value
                    {
                        NumericalValue = 0,
                        Unit = "",
                    },
                    Length = new Data.Model.Value
                    {
                        NumericalValue = 0,
                        Unit = "",
                    },
                    Volume = new Data.Model.Value
                    {
                        NumericalValue = 0,
                        Unit = "",
                    }

                },
            });
            _dbContext.SaveChanges();

            return true;
        }
    }
}
