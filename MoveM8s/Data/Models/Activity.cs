using System.Text.Json.Serialization;

namespace MoveM8s.Data.Models;

public class Activity
{
    public Properties Properties { get; set; }
    public Geometry Geometry { get; set; }
}
