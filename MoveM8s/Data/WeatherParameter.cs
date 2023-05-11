namespace MoveM8s.Data;

public class WeatherParameter
{
    public string Name { get; set; }
    public string LevelType { get; set; }
    public int Level { get; set; }
    public IEnumerable<decimal> Values { get; set; }
}