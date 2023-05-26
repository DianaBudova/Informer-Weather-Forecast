using System.Text.Json.Serialization;

namespace InformerWeatherForecast.Model.AccuWeatherGeoposition;

public class TimeZone
{
    [JsonPropertyName("Code")]
    public string Code { get; set; }

    [JsonPropertyName("Name")]
    public string Name { get; set; }

    [JsonPropertyName("GmtOffset")]
    public double GmtOffset { get; set; }

    [JsonPropertyName("IsDaylightSaving")]
    public bool IsDaylightSaving { get; set; }

    [JsonPropertyName("NextOffsetChange")]
    public DateTime NextOffsetChange { get; set; }
}


