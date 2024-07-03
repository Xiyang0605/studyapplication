using Microsoft.AspNetCore.Mvc;

namespace firstAttempt
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApplicationController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello World");
        }
    } 
    
}
