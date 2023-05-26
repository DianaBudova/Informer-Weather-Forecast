using System.Text.Json.Serialization;

namespace InformerWeatherForecast.Model.AccuWeather1Day;

public class Maximum
{
    [JsonPropertyName("Value")]
    public double Value { get; set; }

    [JsonPropertyName("Unit")]
    public string Unit { get; set; }

    [JsonPropertyName("UnitType")]
    public int UnitType { get; set; }

    [JsonPropertyName("Phrase")]
    public string Phrase { get; set; }
}
