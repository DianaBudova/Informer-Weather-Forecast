namespace InformerWeatherForecast.Common;

/// <summary>
/// Contains general data and methods for handling this data
/// </summary>
public static class Common
{
    public static string[] APIProviders = { "AccuWeather", "WeatherApi" };

    /// <summary>
    /// Contains a list of temperature units:
    /// /// °F - Fahrenheit
    /// °C - Celsius
    /// K - Kelvin
    /// </summary>
    public static string[] TemperatureUnits = { "°F", "°C", "K" };

    public static double FromFahrenheitToCelsius(double f) =>
        Math.Round((f - 32) / 1.8, 1);

    public static double FromFahrenheitToKelvin(double f) =>
        Math.Round((f - 32) / 1.8 + 273.15, 1);

    public static double FromCelsiusToFahrenheit(double c) =>
        Math.Round((c * 1.8) + 32, 1);

    public static double FromCelsiusToKelvin(double c) =>
        Math.Round(c + 273.15, 1);

    public static double FromKelvinToFahrenheit(double k) =>
        Math.Round((k - 273.15) * 1.8 + 32, 1);

    public static double FromKelvinToCelsius(double k) =>
        Math.Round(k - 273.15, 1);

    /// <summary>
    /// Contains a list of wind units:
    /// mph - miles per hour
    /// kt - knots
    /// m/s - meteres per second
    /// ft/s - feet per second
    /// kp/h - kilometeres per hour
    /// </summary>
    public static string[] WindUnits = { "mph", "m/s", "kp/h" };

    public static double FromMphToMs(double mph) =>
        Math.Round(mph / 2.237);

    public static double FromMphToKph(double mph) =>
        Math.Round(mph * 1.609);

    public static double FromMsToMph(double ms) =>
        Math.Round(ms * 2.237);

    public static double FromMsToKph(double ms) =>
        Math.Round(ms * 3.6);

    public static double FromKphToMph(double kph) =>
        Math.Round(kph / 1.609);

    public static double FromKphToMs(double kph) =>
        Math.Round(kph / 3.6);

    /// <summary>
    /// Contains a list of pressure units:
    /// Pa - Pascal
    /// bar - bar
    /// </summary>
    public static string[] PressureUnits = { "Pa", "bar" };

    public static double FromPascalToBar(double pa) =>
        Math.Round(pa / 100000);

    public static double FromBarToPascal(double bar) =>
        Math.Round(bar * 100000);

    public static string[] Days = { "1", "5" };

    public static string[] Maps = { "Clouds", "Rain", "Temperature", "Wind", "Humidity", "Snow" };
}