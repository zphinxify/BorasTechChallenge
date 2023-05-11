namespace MoveM8s.Data
{
    public class TimeSeries
    {
        public DateTime ValidTime { get; set; }
        public IEnumerable<WeatherParameter> Parameters { get; set; }

    }
}