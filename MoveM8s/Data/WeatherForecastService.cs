using MoveM8s.Data.Dtos;
using MoveM8s.Data.Enums;
using System.Text.Json;

namespace MoveM8s.Data;

public class WeatherForecastService
{
    private readonly HttpClient _client = new HttpClient();

    public WeatherForecastService()
    {
        _client.BaseAddress = new Uri("https://opendata-download-metfcst.smhi.se");
    }

    public async Task<List<WeatherForecastResponseDto>> GetForecastAsync(string lon, string lat)
    {
        var weatherForecasts = new List<WeatherForecastResponseDto>();
        var weatherForecastResponse = await GetWeatherForecastsAsync(lon, lat);
        if (weatherForecastResponse != null)
        {
            foreach (var response in weatherForecastResponse.TimeSeries)
            {
                weatherForecasts.Add(new WeatherForecastResponseDto
                {
                    Time = response.ValidTime,
                    TemperatureC = response.Parameters.First(p => p.Name == "t").Values.FirstOrDefault().ToString(),
                    WindSpeed = response.Parameters.First(p => p.Name == "ws").Values.FirstOrDefault().ToString(),
                    WindDirection = response.Parameters.First(p => p.Name == "wd").Values.FirstOrDefault().ToString(),
                    Weather = (WeatherSymbol)response.Parameters.First(p => p.Name == "Wsymb2").Values.FirstOrDefault(),
                    PrecipitationCategory = (PrecipitationCategory)response.Parameters.First(p => p.Name == "pcat").Values.FirstOrDefault()
                });
            }
        }
        return weatherForecasts;
    }

    private async Task<WeatherForecast> GetWeatherForecastsAsync(string lon, string lat)
    {
        return await GetAsync<WeatherForecast>($"/api/category/pmp3g/version/2/geotype/point/lon/{lon}/lat/{lat}/data.json");
    }

    private async Task<WeatherForecast> GetAsync<T>(string requestUri)
    {
        var response = await _client.GetAsync(requestUri);
        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<WeatherForecast>(content, options: new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return result;
        }
        else
        {
            Console.WriteLine($"Error: {response.StatusCode}");
            return new WeatherForecast();
        }
    }
}
