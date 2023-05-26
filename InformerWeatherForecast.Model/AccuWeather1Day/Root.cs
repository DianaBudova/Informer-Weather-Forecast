using System.Text.Json.Serialization;

namespace InformerWeatherForecast.Model.AccuWeather1Day;

public class Root
{
    [JsonPropertyName("Headline")]
    public Headline Headline { get; set; }

    [JsonPropertyName("DailyForecasts")]
    public List<DailyForecast> DailyForecasts { get; set; }
}
