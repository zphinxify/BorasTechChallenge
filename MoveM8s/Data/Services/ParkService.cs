using MoveM8s.Data.Models;
using System.Text.Json;

namespace MoveM8s.Data.Services
{
    public class ParkService
    {
        private static string _parkUrl = "https://catalog.boras.se/store/1/resource/77";

        public async Task<ActivityCollection> GetParkActivitiesAsync()
        {
            using var client = new HttpClient();
            var response = await client.GetAsync(_parkUrl);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<ActivityCollection>(content, options: new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                return result;
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode}");
                return new ActivityCollection();
            }
        }
    }
}
