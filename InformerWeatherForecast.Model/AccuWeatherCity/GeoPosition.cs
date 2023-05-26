using System.Text.Json.Serialization;

namespace InformerWeatherForecast.Model.AccuWeatherCity;

public class GeoPosition
{
    [JsonPropertyName("Latitude")]
    public double Latitude { get; set; }

    [JsonPropertyName("Longitude")]
    public double Longitude { get; set; }

    [JsonPropertyName("Elevation")]
    public Elevation Elevation { get; set; }
}
