using System.Text.Json.Serialization;

namespace InformerWeatherForecast.Model.AccuWeather1Day;

public class Direction
{
    [JsonPropertyName("Degrees")]
    public int Degrees { get; set; }

    [JsonPropertyName("Localized")]
    public string Localized { get; set; }

    [JsonPropertyName("English")]
    public string English { get; set; }
}
