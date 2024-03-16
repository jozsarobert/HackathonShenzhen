using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tracking.Api.Dto;

namespace Tracking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        public FlightController()
        {
            
        }

        [HttpGet("getbyflight")]
        public FlightDto GetShipmentsForFlight(string flightNo, DateTime date)
        {
            return new FlightDto
            {
            };
        }
    }
}
