using System.Text.Json.Serialization;

namespace InformerWeatherForecast.Model.AccuWeatherCity;

public class ParentCity
{
    [JsonPropertyName("Key")]
    public string Key { get; set; }

    [JsonPropertyName("LocalizedName")]
    public string LocalizedName { get; set; }

    [JsonPropertyName("EnglishName")]
    public string EnglishName { get; set; }
}
