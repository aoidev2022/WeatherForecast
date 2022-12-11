using Microsoft.AspNetCore.Mvc;

namespace weatherforecast.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        readonly IConfiguration _configuration;

        public ValuesController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var value = _configuration["values:value-1"];
            await Task.CompletedTask;
            return Ok(value);
        }
    }
}
