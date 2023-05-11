using MoveM8s.Data.Models;
using System.Text.Json;

namespace MoveM8s.Data.Services;

public class GenericActivityService
{
    public async Task<ActivityCollection> GetGenericActivities(string typeOfActivity, string url)
    {
        using var client = new HttpClient();
        var response = await client.GetAsync(url);
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
            Console.WriteLine($"Error when fetching {typeOfActivity}data: {response.StatusCode}");
            return new ActivityCollection();
        }
    }
}
