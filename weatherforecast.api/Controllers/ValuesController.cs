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

        [HttpGet("AppSettings")]
        public async Task<IActionResult> Get()
        {
            var x = _configuration.AsEnumerable();
            await Task.CompletedTask;
            return Ok(x);
        }

        [HttpGet("Environment")]
        public async Task<IActionResult> GetEnvironment()
        {
            var value = _configuration["values:value-1"];
            var environment = Environment.GetEnvironmentVariables();
            await Task.CompletedTask;
            return Ok(environment);
        }
    }
}
