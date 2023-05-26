using InformerWeatherForecast.Common;
using InformerWeatherForecast.Model.Common;
using System.Net.Http.Json;

namespace InformerWeatherForecast.APIConnector;

public class AccuWeatherAPI : ICommonAPI
{
    private readonly HttpClient httpClient;
    private const string apiKey = "hz76ODHp6aAiPdiyM6js8AGsWVR7fS9c";
    //14HXJCFRot1wqxyNutC6LEFT6Hr2Fuiw
    //hz76ODHp6aAiPdiyM6js8AGsWVR7fS9c

    public AccuWeatherAPI() =>
        httpClient = new();

    public WeatherInfo GetCurrentWeatherByCity(City city)
    {
        try
        {
            var geopositionInfo = GetInfoByGeoposition(city.Latitude, city.Longitude);
            if (geopositionInfo is null)
                throw new Exception("Input city contains incorrect data");
            var root = httpClient
                .GetFromJsonAsync<Model.AccuWeather1Day.Root?>
                ($"http://dataservice.accuweather.com/forecasts/v1/daily/1day/{geopositionInfo.Key}?apikey={apiKey}&details=true")
                .Result;
            if (root is null)
                throw new Exception("Data was not received from site");
            return new WeatherInfo()
            {
                City = city,
                Date = root.DailyForecasts.First().Date,
                Temp = root.DailyForecasts.First().Temperature.Minimum.Value,
                UnitTemp = Common.Common.TemperatureUnits[0],
                Clouds = root.DailyForecasts.First().Day.CloudCover,
                WindSpeed = root.DailyForecasts.First().Day.Wind.Speed.Value,
                UnitWind = Common.Common.WindUnits[0],
                WindDirectionDegrees = root.DailyForecasts.First().Day.Wind.Direction.Degrees,
                WindDirectionLocalized = root.DailyForecasts.First().Day.Wind.Direction.Localized,
                HasPrecipitation = root.DailyForecasts.First().Day.HasPrecipitation,
                Icon = ConvertIconToBytes(root.DailyForecasts.First().Day.Icon.ToString()),
            };
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public List<WeatherInfo> GetWeatherFiveDaysByCity(City city)
    {
        try
        {
            var geopositionInfo = GetInfoByGeoposition(city.Latitude, city.Longitude);
            if (geopositionInfo is null)
                throw new Exception("Input city contains incorrect data");
            var root = httpClient
                .GetFromJsonAsync<Model.AccuWeather5Day.Root?>
                ($"http://dataservice.accuweather.com/forecasts/v1/daily/5day/{geopositionInfo.Key}?apikey={apiKey}&details=true")
                .Result;
            if (root is null)
                throw new Exception("Data was not received from site");
            List<WeatherInfo> result = new();
            foreach (var day in root.DailyForecasts)
                result.Add(new WeatherInfo()
                {
                    City = city,
                    Date = day.Date,
                    Temp = day.Temperature.Minimum.Value,
                    UnitTemp = Common.Common.TemperatureUnits[0],
                    HasPrecipitation = day.Day.HasPrecipitation,
                    Icon = ConvertIconToBytes(day.Day.Icon.ToString()),
                });
            return result;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public List<City> GetAllCitiesByCity(string cityName)
    {
        try
        {
            var cities = httpClient
                .GetFromJsonAsync<List<Model.AccuWeatherCity.Root>?>
                ($"http://dataservice.accuweather.com/locations/v1/cities/search?apikey={apiKey}&q={cityName}")
                .Result;
            if (cities.Count == 0)
                throw new Exception("There are no cities");
            List<City> result = new();
            foreach (var city in cities)
                result.Add(new City()
                {
                    CityName = city.EnglishName,
                    Country = city.Country.EnglishName,
                    AdministrativeArea = city.AdministrativeArea.EnglishName,
                    Latitude = city.GeoPosition.Latitude.ToString(),
                    Longitude = city.GeoPosition.Longitude.ToString()
                });
            return result;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    private Model.AccuWeatherGeoposition.Root? GetInfoByGeoposition(string lat, string lon)
    {
        try
        {
            return httpClient
                .GetFromJsonAsync<Model.AccuWeatherGeoposition.Root?>
                ($"http://dataservice.accuweather.com/locations/v1/cities/geoposition/search?apikey={apiKey}&q={lat}%2C{lon}")
                .Result;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    private byte[] ConvertIconToBytes(string icon)
    {
        try
        {
            return File
                .ReadAllBytes(@$"..\..\..\..\InformerWeatherForecast.Model\AccuWeatherIcons\{icon}.png");
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
