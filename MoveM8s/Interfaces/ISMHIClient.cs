using MoveM8s.Data;

namespace MoveM8s.Interfaces;

public interface ISMHIClient
{
    Task<WeatherForecast> GetWeatherForecastsAsync();
}
