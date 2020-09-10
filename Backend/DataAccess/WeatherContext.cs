using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.DataAccess
{
    public class WeatherContext : DbContext
    {
        public WeatherContext(DbContextOptions options) : base(options) { }

        public DbSet<WeatherForecast> WeatherForecasts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WeatherForecast>().HasData(new[]
            {
                new WeatherForecast() { Date = new DateTime(2020, 08, 01), Id = 1, Summary = "Freezing", TemperatureC = 0},
                new WeatherForecast() { Date = new DateTime(2020, 08, 02), Id = 2, Summary = "Bracing", TemperatureC = 5},
                new WeatherForecast() { Date = new DateTime(2020, 08, 03), Id = 3, Summary = "Chilly", TemperatureC = 10},
                new WeatherForecast() { Date = new DateTime(2020, 08, 04), Id = 4, Summary = "Mild", TemperatureC = 15},
                new WeatherForecast() { Date = new DateTime(2020, 08, 05), Id = 5, Summary = "Warm", TemperatureC = 20},
                new WeatherForecast() { Date = new DateTime(2020, 08, 06), Id = 6, Summary = "Balmy", TemperatureC = 25},
                new WeatherForecast() { Date = new DateTime(2020, 08, 07), Id = 7, Summary = "Hot", TemperatureC = 30},
                new WeatherForecast() { Date = new DateTime(2020, 08, 08), Id = 8, Summary = "Sweltering", TemperatureC = 35},
                new WeatherForecast() { Date = new DateTime(2020, 08, 09), Id = 9, Summary = "Scorching", TemperatureC = 40}
            });
        }
    }
}
