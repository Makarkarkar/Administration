using Administration.Services;
using Microsoft.AspNetCore.Mvc;

namespace Administration.Controllers
{
    [ApiController]
    [Route("/")]
    public class HealthCheckController : ControllerBase
    {

        [HttpGet("/healthy")]
        public ActionResult HealthyCheck()
        {
            return Ok("Healthy");
        }
    }
}
