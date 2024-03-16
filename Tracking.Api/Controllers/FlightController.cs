using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tracking.Api.Dto;
using Tracking.Api.Services;

namespace Tracking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        private readonly IFlightService _flightService;  
        public FlightController(IFlightService flightService)
        {
            _flightService = flightService;
        }

        [HttpGet("getbyflight")]
        public FlightDto GetShipmentsForFlight(string flightNo, DateTime date)
        {
            Console.WriteLine("test");
            return _flightService.GetFlightByDateAndFlightNo(date, flightNo);
        }
    }
}
