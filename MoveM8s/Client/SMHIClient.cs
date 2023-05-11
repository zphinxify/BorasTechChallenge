using MoveM8s.Data;
using MoveM8s.Interfaces;

namespace MoveM8s.Client
{
    public class SMHIClient : BaseClient, ISMHIClient
    {
        public SMHIClient(): base(new Uri("https://opendata-download-metfcst.smhi.se"))
        {
        }

        public async Task<WeatherForecast> GetWeatherForecastsAsync()
        {
            return await GetAsync<WeatherForecast>("/api/category/pmp3g/version/2/geotype/point/lon/12.939743/lat/57.725234/data.json");
        }
    }
}
