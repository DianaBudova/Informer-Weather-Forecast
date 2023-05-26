using System.Text.Json.Serialization;

namespace InformerWeatherForecast.Model.AccuWeather1Day;

public class RealFeelTemperature
{
    [JsonPropertyName("Minimum")]
    public Minimum Minimum { get; set; }

    [JsonPropertyName("Maximum")]
    public Maximum Maximum { get; set; }
}
