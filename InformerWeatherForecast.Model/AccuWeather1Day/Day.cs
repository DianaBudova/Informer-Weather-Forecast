using System.Text.Json.Serialization;

namespace InformerWeatherForecast.Model.AccuWeather1Day;

public class Day
{
    [JsonPropertyName("Icon")]
    public int Icon { get; set; }

    [JsonPropertyName("IconPhrase")]
    public string IconPhrase { get; set; }

    [JsonPropertyName("HasPrecipitation")]
    public bool HasPrecipitation { get; set; }

    [JsonPropertyName("ShortPhrase")]
    public string ShortPhrase { get; set; }

    [JsonPropertyName("LongPhrase")]
    public string LongPhrase { get; set; }

    [JsonPropertyName("PrecipitationProbability")]
    public int PrecipitationProbability { get; set; }

    [JsonPropertyName("ThunderstormProbability")]
    public int ThunderstormProbability { get; set; }

    [JsonPropertyName("RainProbability")]
    public int RainProbability { get; set; }

    [JsonPropertyName("SnowProbability")]
    public int SnowProbability { get; set; }

    [JsonPropertyName("IceProbability")]
    public int IceProbability { get; set; }

    [JsonPropertyName("Wind")]
    public Wind Wind { get; set; }

    [JsonPropertyName("WindGust")]
    public WindGust WindGust { get; set; }

    [JsonPropertyName("TotalLiquid")]
    public TotalLiquid TotalLiquid { get; set; }

    [JsonPropertyName("Rain")]
    public Rain Rain { get; set; }

    [JsonPropertyName("Snow")]
    public Snow Snow { get; set; }

    [JsonPropertyName("Ice")]
    public Ice Ice { get; set; }

    [JsonPropertyName("HoursOfPrecipitation")]
    public double HoursOfPrecipitation { get; set; }

    [JsonPropertyName("HoursOfRain")]
    public double HoursOfRain { get; set; }

    [JsonPropertyName("HoursOfSnow")]
    public double HoursOfSnow { get; set; }

    [JsonPropertyName("HoursOfIce")]
    public double HoursOfIce { get; set; }

    [JsonPropertyName("CloudCover")]
    public int CloudCover { get; set; }

    [JsonPropertyName("Evapotranspiration")]
    public Evapotranspiration Evapotranspiration { get; set; }

    [JsonPropertyName("SolarIrradiance")]
    public SolarIrradiance SolarIrradiance { get; set; }
}
