using MoveM8s.Data.Models;

namespace MoveM8s.Data.Services;

public class ActivityService
{
    public async Task<ActivityCollection> GetActivities()
    {
        //return new List<Activity>
        //{
        //    new Activity { Title = "Simma", Description = "Ta på dig badkläderna och ta några simtag i fin natur", Location = "Almenäs" },
        //    new Activity { Title = "Hundlek", Description = "Ta med dig din fyrbenta bästis och njut av det fina vädret ihop", Location = "Kransmossen" },
        //    new Activity { Title = "Promenera", Description = "Njut av vackra omgivningar längs med viskan på grusade gångar där du även kan ta med dig barnvagnen", Location = "Stadsparken" }
        //};


        return new ActivityCollection
        {
            Activites = new List<Activity>
            {
                new Activity
                {
                    Geometry = new Geometry
                    {
                        Coordinates = new List<double>
                        {
                            20.12390349578,
                            51.32498673487
                        },
                        Type = "type :)"

                    },
                    Properties = new Properties
                    {
                        Description = "Ta på dig badkläderna och ta några simtag i fin natur",
                        Name = "Almenäs",
                        VisitUrl = "boras.se",
                        
                    }
                },
                new Activity
                {
                    Geometry = new Geometry
                    {
                        Coordinates = new List<double>
                        {
                            20.12390349578,
                            51.32498673487
                        }
                    },
                    Properties = new Properties
                    {
                        Description = "Ta med dig din fyrbenta bästis och njut av det fina vädret ihop",
                        Name = "Ryaåsar",
                        VisitUrl = "boras.se",

                    }
                },
                new Activity
                {
                    Geometry = new Geometry
                    {
                        Coordinates = new List<double>
                        {
                            20.12390349578,
                            51.32498673487
                        }
                    },
                    Properties = new Properties
                    {
                        Description = "Njut av vackra omgivningar längs med viskan på grusade gångar där du även kan ta med dig barnvagnen",
                        Name = "OuterSpace",
                        VisitUrl = "boras.se",

                    }
                }
            }
        };
    }
}
