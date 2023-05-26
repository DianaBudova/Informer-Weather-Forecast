using InformerWeatherForecast.Common;
using InformerWeatherForecast.Model.Common;

namespace InformerWeatherForecast.BL;

public class APIConnectorMediator
{
    private readonly ICommonAPI api;

    public APIConnectorMediator(ICommonAPI api) =>
        this.api = api;

    public WeatherInfo GetCurrentWeatherByCity(City city) =>
        this.api.GetCurrentWeatherByCity(city);

    public List<WeatherInfo> GetWeatherFiveDaysByCity(City city) =>
        this.api.GetWeatherFiveDaysByCity(city);

    public List<City> GetAllCitiesByCityName(string cityName) =>
        this.api.GetAllCitiesByCity(cityName);
}
