using System.Text.Json.Serialization;

namespace InformerWeatherForecast.Model.AccuWeather1Day;

public class Speed
{
    [JsonPropertyName("Value")]
    public double Value { get; set; }

    [JsonPropertyName("Unit")]
    public string Unit { get; set; }

    [JsonPropertyName("UnitType")]
    public int UnitType { get; set; }
}
