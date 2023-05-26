using System.Text.Json.Serialization;

namespace InformerWeatherForecast.Model.WeatherApiCurrent;

public class Condition
{
    [JsonPropertyName("text")]
    public string Text { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; }

    [JsonPropertyName("code")]
    public int Code { get; set; }
}
