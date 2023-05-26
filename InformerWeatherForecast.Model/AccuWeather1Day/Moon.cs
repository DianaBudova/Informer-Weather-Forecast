using System.Text.Json.Serialization;

namespace InformerWeatherForecast.Model.AccuWeather1Day;

public class Moon
{
    [JsonPropertyName("Rise")]
    public DateTime Rise { get; set; }

    [JsonPropertyName("EpochRise")]
    public int EpochRise { get; set; }

    [JsonPropertyName("Set")]
    public DateTime Set { get; set; }

    [JsonPropertyName("EpochSet")]
    public int EpochSet { get; set; }

    [JsonPropertyName("Phase")]
    public string Phase { get; set; }

    [JsonPropertyName("Age")]
    public int Age { get; set; }
}
