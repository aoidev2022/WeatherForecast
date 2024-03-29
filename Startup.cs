using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

using Serilog;

using System;

using WeatherForecast.DB;

namespace WeatherForecast
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // var connString = Configuration.GetConnectionString("Db");
            // var simpleProperty = Configuration.GetValue<string>("SimpleProperty");
            // var nestedProperty = Configuration.GetValue<string>("Inventory:NestedProperty");

            // Log
            //     .ForContext("Db Connection String", connString)
            //     .ForContext("Simple Property", simpleProperty)
            //     .ForContext("Nested Property", nestedProperty)
            //     .Information("Loaded Configuration!");

            var dbgView = (Configuration as IConfigurationRoot).GetDebugView();
            Log.ForContext("ConfigurationDebug", dbgView).Information("Configuration Dump");

            services.AddDbContext<ApplicationDbContext>(options =>
            {
                if (!string.IsNullOrWhiteSpace(Configuration.GetConnectionString("Db")))
                    options.UseSqlServer(Configuration.GetConnectionString("DB"));
                else
                    options.UseInMemoryDatabase("weatherforecast");
            });

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WeatherForecast API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (true || env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", $"WeatherForecast v1 - TAG {Environment.GetEnvironmentVariable("TAG")}");
                });
            }

            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var dbContext = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

                if (dbContext.Database.IsRelational())
                    dbContext.Database.Migrate();

                if (dbContext.Database.IsInMemory())
                    Seeder.SeedInMemoryData(dbContext);
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
