using Microsoft.EntityFrameworkCore;

using System;
using System.Linq;

namespace WeatherForecast.DB
{
    public class ApplicationDbContext : DbContext
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<WeatherForecast> WeatherForecasts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var rng = new Random();
            var items = Enumerable.Range(1, 50).Select(index => new WeatherForecast
            {
                Id = index,
                Date = DateTime.Now.AddDays(rng.Next(-20, 20)),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray();

            modelBuilder.Entity<WeatherForecast>().HasData(items);

            base.OnModelCreating(modelBuilder);
        }
    }
}
