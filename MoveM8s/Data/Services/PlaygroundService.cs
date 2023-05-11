using Microsoft.AspNetCore.Http.Features;
using MoveM8s.Data.Models;
using System.Text.Json;

namespace MoveM8s.Data.Services;

public class PlaygroundService
{
    private static string _playgroundUrl = "https://catalog.boras.se/store/1/resource/74";

    public async Task<ActivityCollection> GetPlaygroundActivitiesAsync()
    {
        using var client = new HttpClient();
        var response = await client.GetAsync(_playgroundUrl);
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
