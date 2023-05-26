using System.Text.Json.Serialization;

namespace InformerWeatherForecast.Model.AccuWeatherCity;

public class Region
{
    [JsonPropertyName("ID")]
    public string ID { get; set; }

    [JsonPropertyName("LocalizedName")]
    public string LocalizedName { get; set; }

    [JsonPropertyName("EnglishName")]
    public string EnglishName { get; set; }
}
