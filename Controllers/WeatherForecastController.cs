using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

using Serilog;

using System;
using System.Collections.Generic;
using System.Linq;

namespace WeatherForecast.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public WeatherForecastController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            Log.ForContext("custom", "epa").Information("starting WeatherForecast get");

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
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
