using System.Text.Json.Serialization;

namespace MoveM8s.Data.Models
{
    public class ActivityCollection
    {
        [JsonPropertyName("features")]
        public List<Activity> Activities { get; set; }
    }
}
