using Microsoft.AspNetCore.Http.HttpResults;

namespace TutorialWebApi.Services
{
    public class GetWeatherService2
    {
        private readonly WeatherDataService _service;
        public GetWeatherService2(WeatherDataService service)
        {
            _service = service;
        }
        public WeatherForecast[] GetWeatherData()
        {
            return _service.GetWeatherData();
        }
    }
}
