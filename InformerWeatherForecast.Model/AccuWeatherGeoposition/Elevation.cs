using System.Text.Json.Serialization;

namespace InformerWeatherForecast.Model.AccuWeatherGeoposition;

public class Elevation
{
    [JsonPropertyName("Metric")]
    public Metric Metric { get; set; }

    [JsonPropertyName("Imperial")]
    public Imperial Imperial { get; set; }
}


