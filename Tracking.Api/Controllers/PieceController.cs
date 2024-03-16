using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tracking.Api.Dto;

namespace Tracking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PieceController : ControllerBase
    {
        public PieceController()
        {
            
        }

        [HttpGet("getbyid")]
        public PieceDto GetPieceById(int id) 
        {
            return new PieceDto { Id = id };
        }

        [HttpGet("getbyshipmentid")]
        public IEnumerable< PieceDto> GetPiecesByShipmentId(int id)
        {
            return new List<PieceDto> { new PieceDto { Id = id } };
        }
    }
}
