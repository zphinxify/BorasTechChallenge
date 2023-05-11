using MoveM8s.Data.Models;

namespace MoveM8s.Data.Services;

public class ActivityService
{
    public async Task<IEnumerable<ActivityFeature>> GetActivities()
    {
        return new List<ActivityFeature>
        {
            new ActivityFeature { Name = "Simma", Description = "Ta på dig badkläderna och ta några simtag i fin natur", VisitUrl = "Almenäs" },
            new ActivityFeature { Name = "Hundlek", Description = "Ta med dig din fyrbenta bästis och njut av det fina vädret ihop", VisitUrl = "Kransmossen" },
            new ActivityFeature { Name = "Promenera", Description = "Njut av vackra omgivningar längs med viskan på grusade gångar där du även kan ta med dig barnvagnen", VisitUrl = "Stadsparken" }
        };
    }
}
