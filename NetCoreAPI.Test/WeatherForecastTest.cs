using Microsoft.Extensions.Logging;
using NetCoreAPI.Controllers;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Moq;

namespace NetCoreAPI.Test
{
    public class WeatherForecastTest
    {

        //private readonly ILogger<WeatherForecastController> _logger;
        WeatherForecastController controller;

        public WeatherForecastTest()
        {
            var _logger = new Mock<ILogger<WeatherForecastController>>();
            controller = new  WeatherForecastController(_logger.Object);
        }

        [Fact]
        public void GetReturnsAllWeatherForecasts()
        {
            IEnumerable<WeatherForecast> returnVal = controller.Get().ToList();
            Assert.Equal(5, returnVal.Count());
        }
    }
}s