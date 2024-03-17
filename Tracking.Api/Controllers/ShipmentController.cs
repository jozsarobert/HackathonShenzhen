using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tracking.Api.Dto;
using Tracking.Api.Services;

namespace Tracking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipmentController : ControllerBase
    {
        private readonly IShipmentService _shipmentService;
        public ShipmentController(IShipmentService shipmentService)
        {
            _shipmentService = shipmentService;
        }

        [HttpGet("getbyid")]
        public ShipmentDto GetShipmentById(int id)
        {
            return _shipmentService.GetShipmentById(id);
        }

        [HttpGet("getwithalerts")]
        public List<ShipmentDto> GetShipmentWithAlerts()
        {
            return _shipmentService.GetShipmentWithAlerts();
        }
    }
}
