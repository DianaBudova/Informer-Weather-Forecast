using System.Text.Json.Serialization;

namespace InformerWeatherForecast.Model.WeatherApiForecast;

public class Forecast
{
    [JsonPropertyName("forecastday")]
    public List<Forecastday> Forecastday { get; set; }
}
