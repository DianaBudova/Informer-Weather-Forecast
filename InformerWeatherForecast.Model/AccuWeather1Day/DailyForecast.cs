using System.Text.Json.Serialization;

namespace InformerWeatherForecast.Model.AccuWeather1Day;

public class DailyForecast
{
    [JsonPropertyName("Date")]
    public DateTime Date { get; set; }

    [JsonPropertyName("EpochDate")]
    public int EpochDate { get; set; }

    [JsonPropertyName("Sun")]
    public Sun Sun { get; set; }

    [JsonPropertyName("Moon")]
    public Moon Moon { get; set; }

    [JsonPropertyName("Temperature")]
    public Temperature Temperature { get; set; }

    [JsonPropertyName("RealFeelTemperature")]
    public RealFeelTemperature RealFeelTemperature { get; set; }

    [JsonPropertyName("RealFeelTemperatureShade")]
    public RealFeelTemperatureShade RealFeelTemperatureShade { get; set; }

    [JsonPropertyName("HoursOfSun")]
    public double HoursOfSun { get; set; }

    [JsonPropertyName("DegreeDaySummary")]
    public DegreeDaySummary DegreeDaySummary { get; set; }

    [JsonPropertyName("AirAndPollen")]
    public List<AirAndPollen> AirAndPollen { get; set; }

    [JsonPropertyName("Day")]
    public Day Day { get; set; }

    [JsonPropertyName("Night")]
    public Night Night { get; set; }

    [JsonPropertyName("Sources")]
    public List<string> Sources { get; set; }

    [JsonPropertyName("MobileLink")]
    public string MobileLink { get; set; }

    [JsonPropertyName("Link")]
    public string Link { get; set; }
}
