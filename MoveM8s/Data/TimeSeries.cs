namespace MoveM8s.Data
{
    public class TimeSeries
    {
        public DateTime ValidTime { get; set; }
        public WeatherParameter[] Parameters { get; set; }

    }
}