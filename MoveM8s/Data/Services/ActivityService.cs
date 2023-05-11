using MoveM8s.Data.Models;

namespace MoveM8s.Data.Services;

public class ActivityService
{
    private readonly PlaygroundService _playgroundService;
    private readonly ParkService _parkService;

    public ActivityService(PlaygroundService playgroundService, ParkService parkService)
    {
        _playgroundService = playgroundService;
        _parkService = parkService;
    }

    public async Task<IEnumerable<Activity>> GetActivitiesAsync()
    {
        var list = new List<Activity>();

        var parkActivities = await _parkService.GetParkActivitiesAsync();
        var playgroundActivities = await _playgroundService.GetPlaygroundActivitiesAsync();
        list.AddRange(parkActivities.Activites);
        list.AddRange(playgroundActivities.Activites);

        return list;
    }
}
