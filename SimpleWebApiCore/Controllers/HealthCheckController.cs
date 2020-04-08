using Microsoft.AspNetCore.Mvc;


namespace SimpleWebApiCore.Controllers
{

    public class HealthCheckController:ControllerBase
    {
       
        [HttpGet]
        [Route("api/[controller]")]
        public  IActionResult HealthCheck()
        {
             return Ok("Endpoint is working");
            
        }
    }
}