using System.Text.Json.Serialization;

namespace InformerWeatherForecast.Model.AccuWeather1Day;

public class DegreeDaySummary
{
    [JsonPropertyName("Heating")]
    public Heating Heating { get; set; }

    [JsonPropertyName("Cooling")]
    public Cooling Cooling { get; set; }
}
