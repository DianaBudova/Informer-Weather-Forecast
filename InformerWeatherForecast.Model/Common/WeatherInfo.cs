namespace InformerWeatherForecast.Model.Common;

public class WeatherInfo
{
    public City? City { get; set; }
    public DateTime Date { get; set; }
    public double Temp { get; set; }
    public string? UnitTemp { get; set; }
    public double WindSpeed { get; set; }
    public string? UnitWind { get; set; }
    public int WindDirectionDegrees { get; set; }
    public string? WindDirectionLocalized { get; set; }
    public int Clouds { get; set; }
    public double Pressure { get; set; }
    public string? UnitPressure { get; set; }
    public double Humidity { get; set; }
    public bool HasPrecipitation { get; set; }
    public byte[]? Icon { get; set; }
}
