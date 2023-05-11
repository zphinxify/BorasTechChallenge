using MoveM8s.Data.Enums;

namespace MoveM8s.Data.Dtos;

public class WeatherForecastResponseDto
{
    public DateTime Time { get; set; }
    public string TemperatureC { get; set; }
    public string WindSpeed { get; set; }
    public string WindDirection { get; set; }
    public WeatherSymbol Weather { get; set; }
    public PrecipitationCategory PrecipitationCategory { get; set; }

}
