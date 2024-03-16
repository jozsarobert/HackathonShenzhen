using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tracking.Api.Dto;

namespace Tracking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlertController : ControllerBase
    {
        public AlertController()
        {
            
        }

        [HttpGet("getalerts")]
        public List<AlertDto> GetAlerts()
        {
            return new List<AlertDto>{
                new AlertDto
                {

                }
            };
        }
    }
}
