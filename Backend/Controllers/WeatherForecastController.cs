using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly WeatherContext _dbContext;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, WeatherContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet]
        public WeatherForecast Get()
        {
            var rng = new Random();
            var count = _dbContext.WeatherForecasts.Count();
            var index = rng.Next(1, count);
            var weatherForecast = _dbContext.WeatherForecasts.SingleOrDefault(x => x.Id == index);
            return weatherForecast;
        }
    }
}
