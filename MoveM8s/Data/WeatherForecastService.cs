using MoveM8s.Interfaces;

namespace MoveM8s.Data;

public class WeatherForecastService
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
    private readonly ISMHIClient _client;

    public WeatherForecastService(ISMHIClient client)
    {
        _client = client;
    }

    public Task<WeatherForecast> GetForecastAsync(DateOnly startDate)
    {
        return _client.GetWeatherForecastsAsync();
    //    return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
    //    {
    //        Date = startDate.AddDays(index),
    //        TemperatureC = Random.Shared.Next(-20, 55),
    //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
    //    }).ToArray());
    }
}
