using Microsoft.AspNetCore.Mvc;

namespace dotnetms.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RandomNumberController : ControllerBase
    {
        private static readonly Random random = new Random();

        [HttpGet]
        public ActionResult<string> Get()
        {
            int randomNumber = random.Next();
            string message = $"Hello world {randomNumber}";
            return Ok(message);
        }
    }
}
