using Microsoft.AspNetCore.Mvc;
namespace SimpleApp.Api.Controllers
    {
    [ApiController]
    [Route("[controller]")]
    public class FansController : ControllerBase
        {
        [HttpGet(Name = "GetFans")]
        public async Task<IActionResult> Get()
            {
            return Ok("fans");
            }
        }
    }
