using InformerWeatherForecast.APIConnector;
using InformerWeatherForecast.BL;
using InformerWeatherForecast.Model.Common;

namespace InformerWeatherForecast.UIConsole;

internal class Program
{
    static void Main(string[] args)
    {
        // two controllers with two api providers
        //Controller controller = new(new APIConnectorMediator(APIFactory.GetWeatherApiAPI()), new DatabaseMediator());
        Controller controller = new(new APIConnectorMediator(APIFactory.GetAccuWeatherAPI()), new DatabaseMediator());

        // choose city from list of the same city name
        // in this example, third city is selected from list of cities (Paris, there are four Paris around the world)
        City city = controller.APIConnectorMediator.GetAllCitiesByCityName("Kiev").ElementAt(0);

        // get current weather by city
        WeatherInfo currentWeather = controller.APIConnectorMediator.GetCurrentWeatherByCity(city);
        Console.WriteLine("<----- Current weather ----->\n" +
            $"Date: {currentWeather.Date}\n" +
            $"City: {currentWeather.City?.CityName}\n" +
            $"Region: {currentWeather.City?.AdministrativeArea}\n" +
            $"Country: {currentWeather.City?.Country}\n" +
            $"Temp: {currentWeather.Temp} {currentWeather.UnitTemp}\n" +
            $"Wind speed: {currentWeather.WindSpeed} {currentWeather.UnitWind}\n" +
            $"Wind direction (localized): {currentWeather.WindDirectionLocalized}\n" +
            $"Wind direction (degrees): {currentWeather.WindDirectionDegrees}\n" +
            $"Clouds: {currentWeather.Clouds}\n" +
            $"Precipitation: {(currentWeather.HasPrecipitation ? "yes" : "no")}\n" +
            $"Humidity: {currentWeather.Humidity} %\n" +
            $"Pressure: {currentWeather.Pressure} {currentWeather.UnitPressure}\n");

        List<WeatherInfo> weather5Days = controller.APIConnectorMediator.GetWeatherFiveDaysByCity(city);
        Console.WriteLine("<----- Weather for 5 days ----->");
        foreach (var day in weather5Days)
            Console.WriteLine("---------------------\n" +
                $"Date: {day.Date}\n" +
                $"City: {day.City.CityName}\n" +
                $"Region: {day.City.AdministrativeArea}\n" +
                $"Country: {day.City.Country}\n" +
                $"Temp: {day.Temp} {day.UnitTemp}\n" +
                $"Wind speed: {day.WindSpeed} {day.UnitWind}\n" +
                $"Wind direction (localized): {day.WindDirectionLocalized}\n" +
                $"Wind direction (degrees) {day.WindDirectionDegrees}\n" +
                $"Clouds: {day.Clouds}\n" +
                $"Precipitation: {(currentWeather.HasPrecipitation ? "yes" : "no")}\n" +
                $"Humidity: {day.Humidity} %\n" +
                $"Pressure: {day.Pressure} {day.UnitPressure}\n" +
                "---------------------\n");
    }
}