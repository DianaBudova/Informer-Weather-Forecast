using System.Text.Json.Serialization;

namespace InformerWeatherForecast.Model.AccuWeather1Day;

public class AirAndPollen
{
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    [JsonPropertyName("Value")]
    public int Value { get; set; }

    [JsonPropertyName("Category")]
    public string Category { get; set; }

    [JsonPropertyName("CategoryValue")]
    public int CategoryValue { get; set; }

    [JsonPropertyName("Type")]
    public string Type { get; set; }
}
