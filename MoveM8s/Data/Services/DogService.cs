using MoveM8s.Data.Models;
using System.Text.Json;

namespace MoveM8s.Data.Services;

public class DogService
{
    private static string _dogUrl = "https://catalog.boras.se/store/1/resource/80";
    public DogService()
    {

    }
    public async Task<ActivityCollection> GetDogActivitiesAsync()
    {
        using var client = new HttpClient();
        var response = await client.GetAsync(_dogUrl);
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
            Console.WriteLine($"Error when fetching dog park data: {response.StatusCode}");
            return new ActivityCollection();
        }
    }
}
