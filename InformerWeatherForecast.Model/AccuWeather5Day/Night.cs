using System.Text.Json.Serialization;

namespace InformerWeatherForecast.Model.AccuWeather5Day;

public class Night
{
    [JsonPropertyName("Icon")]
    public int Icon { get; set; }

    [JsonPropertyName("IconPhrase")]
    public string IconPhrase { get; set; }

    [JsonPropertyName("HasPrecipitation")]
    public bool HasPrecipitation { get; set; }
}
