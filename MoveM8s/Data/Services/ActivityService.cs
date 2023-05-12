using MoveM8s.Data.Models;

namespace MoveM8s.Data.Services;

public class ActivityService
{
    private readonly GenericActivityService _genericActivityService;

    public ActivityService(GenericActivityService genericActivityService)
    {
        _genericActivityService = genericActivityService;
    }

    public async Task<IEnumerable<Activity>> GetAllActivitiesAsync()
    {
        var list = new List<Activity>();

        var parkActivities = await _genericActivityService.GetGenericActivities("park", "https://catalog.boras.se/store/1/resource/77");
        var playgroundActivities = await _genericActivityService.GetGenericActivities("playground", "https://catalog.boras.se/store/1/resource/74");
        //var dogServiceActivities = await _genericActivityService.GetGenericActivities("dog", "https://catalog.boras.se/store/1/resource/80");
        var bathHouseServiceActivities = await _genericActivityService.GetGenericActivities("bathhouse", "https://catalog.boras.se/store/1/resource/102");
        var walkTrackActivities = await _genericActivityService.GetGenericActivities("walktrack", "https://catalog.boras.se/store/1/resource/71");
        var swimmingAreaActivities  = await _genericActivityService.GetGenericActivities("swimmingarea", "https://catalog.boras.se/store/1/resource/57");

        if ((bool)parkActivities.Activities?.Any())
        {
            list.AddRange(parkActivities.Activities);
        }
        if ((bool)playgroundActivities.Activities?.Any())
        {
            list.AddRange(playgroundActivities.Activities);
        }
        //list.AddRange(dogServiceActivities.Activities);
        if ((bool)bathHouseServiceActivities.Activities?.Any())
        {
            list.AddRange(bathHouseServiceActivities.Activities);
        }
        if (walkTrackActivities.Activities != null && walkTrackActivities.Activities.Any())
        {
            list.AddRange(walkTrackActivities.Activities);
        }
        if ((bool)swimmingAreaActivities.Activities?.Any())
        {
            list.AddRange(swimmingAreaActivities.Activities);
        }

        return list;
    }
}
