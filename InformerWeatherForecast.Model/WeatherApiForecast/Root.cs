using System.Text.Json.Serialization;

namespace InformerWeatherForecast.Model.WeatherApiForecast;

public class Root
{
    [JsonPropertyName("location")]
    public Location Location { get; set; }

    [JsonPropertyName("current")]
    public Current Current { get; set; }

    [JsonPropertyName("forecast")]
    public Forecast Forecast { get; set; }
}
