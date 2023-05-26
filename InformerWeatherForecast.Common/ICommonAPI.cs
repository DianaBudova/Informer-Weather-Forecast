using InformerWeatherForecast.Model.Common;

namespace InformerWeatherForecast.Common;

public interface ICommonAPI
{
    public WeatherInfo GetCurrentWeatherByCity(City city);
    public List<WeatherInfo> GetWeatherFiveDaysByCity(City city);
    public List<City> GetAllCitiesByCity(string city);
}
