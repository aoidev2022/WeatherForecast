using System;
using System.Linq;

namespace WeatherForecast.DB
{
    public static class Seeder
    {
        public static void SeedInMemoryData(ApplicationDbContext dbContext)
        {
            string[] Summaries = new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };

            var rng = new Random();
            var items = Enumerable.Range(1, 50).Select(index => new DB.WeatherForecast
            {
                Id = index,
                Date = DateTime.Now.AddDays(rng.Next(-20, 20)),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray();

            dbContext.WeatherForecasts.AddRange(items);

            dbContext.SaveChanges();
        }
    }
}
