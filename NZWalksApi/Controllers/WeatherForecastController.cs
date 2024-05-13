using Microsoft.AspNetCore.Mvc;
using NZWalksApi.Business.Models;

namespace NZWalksApi.Controllers
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

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet]
        [Route("GetASpecificWeather")]
        public WeatherForecast GetSpecificWeather()
        {
            WeatherForecast forecast = new WeatherForecast();
            forecast.Date = DateOnly.FromDateTime(DateTime.Now);
            forecast.TemperatureC = 22;
            forecast.Summary = "Het is zo warm, dat ik vijvers laat vloeien uit mijn oksels.";
            return forecast;
        }

        [HttpGet]
        [Route("GetASpecificWeatherWithID/{id:int}")]
        public WeatherForecast GetSpecificWeather(int id)
        {
            WeatherForecast forecast = new WeatherForecast();
            forecast.Date = DateOnly.FromDateTime(DateTime.Now);
            forecast.TemperatureC = 22;
            forecast.Summary = "Het is zo warm, dat ik vijvers laat vloeien uit mijn oksels.";
            return forecast;
        }
    }
}
