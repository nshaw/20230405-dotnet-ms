using Microsoft.AspNetCore.Mvc;

namespace dotnetms.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
              var myObject = new {
                Status = "UP"
            };

            return Ok(myObject);
        }
    }
}
