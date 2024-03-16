using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tracking.Api.Dto;

namespace Tracking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipmentController : ControllerBase
    {

        public ShipmentController() { }

        [HttpGet("getbyid")]
        public ShipmentDto GetShipmentById(string id)
        {
            return new ShipmentDto
            {

            };
        }
    }
}
