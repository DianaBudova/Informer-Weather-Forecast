using InformerWeatherForecast.Common;

namespace InformerWeatherForecast.APIConnector;

public static class APIFactory
{
    public static ICommonAPI GetAccuWeatherAPI() =>
        new AccuWeatherAPI();

    public static ICommonAPI GetWeatherApiAPI() =>
        new WeatherApiAPI();
}
