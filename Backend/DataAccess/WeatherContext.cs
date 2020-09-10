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
    }
}
