using System.Text.Json;

namespace MoveM8s.Client;

public class BaseClient
{
    private readonly HttpClient client = new HttpClient();
    
    public BaseClient(Uri uri)
    {
        client.BaseAddress = uri;
    }

    protected async Task<T> GetAsync<T>(string requestUri)
    {
        var response = await client.GetAsync(requestUri);
        response.EnsureSuccessStatusCode();
        var responseString = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<T>(responseString, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
    }

    protected async Task PostAsync<T>(string requestUri, T content)
    {
        var response = await client.PostAsJsonAsync(requestUri, content);
        response.EnsureSuccessStatusCode();
    }
}
