using MoveM8s.Data.Models;

namespace MoveM8s.Data.Services;

public class ActivityService
{
    public async Task<IEnumerable<Activity>> GetActivities()
    {
        return new List<Activity>
        {
            new Activity { Title = "Simma", Description = "Ta på dig badkläderna och ta några simtag i fin natur", Location = "Almenäs" },
            new Activity { Title = "Hundlek", Description = "Ta med dig din fyrbenta bästis och njut av det fina vädret ihop", Location = "Kransmossen" },
            new Activity { Title = "Promenera", Description = "Njut av vackra omgivningar längs med viskan på grusade gångar där du även kan ta med dig barnvagnen", Location = "Stadsparken" }
        };
    }
}
