using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using Serilog;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WeatherForecast.DB;

namespace WeatherForecast.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly ApplicationDbContext _context;

        public WeatherForecastController(IConfiguration configuration, ApplicationDbContext context)
        {
            _configuration = configuration;
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DB.WeatherForecast>>> Get()
        {
            Log.ForContext("custom", "epa").Information("starting WeatherForecast get");

            return Ok(await _context.WeatherForecasts.ToListAsync());
        }

        [HttpGet("GetEnvironmentVariables")]
        public IActionResult GetEnvironmentVariables()
        {
            return new JsonResult(Environment.GetEnvironmentVariables());
        }

        [HttpGet("GetAppSettings")]
        public IActionResult GetAppSettings()
        {
            return new JsonResult(_configuration.AsEnumerable());
        }
    }
}
