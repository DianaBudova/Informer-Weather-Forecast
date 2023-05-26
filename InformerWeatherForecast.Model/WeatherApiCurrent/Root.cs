using System.Text.Json.Serialization;

namespace InformerWeatherForecast.Model.WeatherApiCurrent;

public class Root
{
    [JsonPropertyName("location")]
    public Location Location { get; set; }

    [JsonPropertyName("current")]
    public Current Current { get; set; }
}