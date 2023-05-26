using System.Text.Json.Serialization;

namespace InformerWeatherForecast.Model.AccuWeather5Day;

public class Temperature
{
    [JsonPropertyName("Minimum")]
    public Minimum Minimum { get; set; }

    [JsonPropertyName("Maximum")]
    public Maximum Maximum { get; set; }
}
