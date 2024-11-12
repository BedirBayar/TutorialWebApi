using Microsoft.AspNetCore.Mvc;
using TutorialWebApi.Services;

namespace TutorialWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {


        private readonly WeatherDataService _service;
        private readonly GetWeatherService2 _service2;

        public WeatherForecastController(WeatherDataService service, GetWeatherService2 service2)
        {
            _service = service;
            _service2 = service2;
        }

        [HttpGet("getall")]
        public IEnumerable<WeatherForecast> GetAll()
        {
            var data= _service.GetWeatherData();
            Thread.Sleep(2000);
            var data2= _service.GetWeatherData();
            Thread.Sleep(2000);
            var data3= _service2.GetWeatherData();
            Thread.Sleep(2000);
            var data4= _service2.GetWeatherData();
            Thread.Sleep(2000);
            return data4;

        }
        [HttpGet("getalll")]
        public IEnumerable<WeatherForecast> Get1All()
        {
            return _service.GetWeatherData();
        }
        [HttpGet("getallll")]
        public IEnumerable<WeatherForecast> Get2All()
        {
            return _service.GetWeatherData();
        }
        [HttpGet("getalllll")]
        public IEnumerable<WeatherForecast> Get3All()
        {
            return _service.GetWeatherData();
        }
    }
}
