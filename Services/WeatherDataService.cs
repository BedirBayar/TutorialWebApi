namespace TutorialWebApi.Services
{
    public class WeatherDataService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        public DateTime createdOn;
        public WeatherDataService()
        {
            createdOn = DateTime.Now;
        }
        public WeatherForecast[] GetWeatherData()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = createdOn,
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
           .ToArray();
        }
    }
}
