using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tracking.Api.Dto;
using Tracking.Api.Services;
using Tracking.Data.Repositories;

namespace Tracking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PieceController : ControllerBase
    {
        private readonly IPieceService _pieceService;
        public PieceController(IPieceService pieceService)
        {
            _pieceService = pieceService;
        }

        [HttpGet("getbyid")]
        public PieceDto GetPieceById(int id) 
        {
            return _pieceService.GetPieceById(id);
        }

        [HttpGet("getbyshipmentid")]
        public IEnumerable<PieceDto> GetPiecesByShipmentId(int id)
        {
            return _pieceService.GetPieceByShipmentId(id);
        }

        [HttpGet("updatesensor")]
        public void UpdateSensor(int id, string serialNumber, double temperature)
        {
             _pieceService.UpdateSensorData(id, serialNumber,temperature);
        }
    }
}
