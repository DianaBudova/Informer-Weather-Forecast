using InformerWeatherForecast.Common;
using InformerWeatherForecast.Model.Common;
using System.Net.Http.Json;

namespace InformerWeatherForecast.APIConnector;

public class WeatherApiAPI : ICommonAPI
{
    private readonly HttpClient httpClient;
    private const string apiKey = "2b8b0ac264b64af79c5120257231605";

    public WeatherApiAPI()
    {
        httpClient = new();
    }

    public WeatherInfo GetCurrentWeatherByCity(City city)
    {
        try
        {
            var root = httpClient
                .GetFromJsonAsync<Model.WeatherApiCurrent.Root?>
                ($"http://api.weatherapi.com/v1/current.json?key={apiKey}&q={city.Latitude.ToString().Replace(',', '.')},{city.Longitude.ToString().Replace(',', '.')}&aqi=no")
                .Result;
            if (root is null)
                throw new Exception("Data was not received from site");
            string[] temp = root.Location.Localtime.Split('-', ' ', ':');
            return new WeatherInfo()
            {
                City = city,
                Date = new(int.Parse(temp[0]), int.Parse(temp[1]), int.Parse(temp[2]), int.Parse(temp[3]), int.Parse(temp[4]), 0),
                Temp = root.Current.TempC,
                UnitTemp = Common.Common.TemperatureUnits[1],
                Clouds = root.Current.Cloud,
                WindSpeed = root.Current.WindMph,
                UnitWind = Common.Common.WindUnits[0],
                WindDirectionDegrees = root.Current.WindDegree,
                WindDirectionLocalized = root.Current.WindDir,
                Humidity = root.Current.Humidity,
                HasPrecipitation = root.Current.PrecipIn > 0 ? true : false,
                Pressure = root.Current.PressureMb,
                UnitPressure = Common.Common.PressureUnits[1],
                Icon = ConvertIconToBytes(root.Current.Condition.Icon),
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
            var root = httpClient
               .GetFromJsonAsync<Model.WeatherApiForecast.Root?>
               ($"http://api.weatherapi.com/v1/forecast.json?key={apiKey}&q={city.Latitude},{city.Longitude}&days=5&aqi=no&alerts=no")
               .Result;
            if (root is null)
                throw new Exception("Data was not received from site");
            List<WeatherInfo> result = new();
            foreach (var day in root.Forecast.Forecastday)
            {
                string[] date = day.Date.Split('-');
                result.Add(new WeatherInfo()
                {
                    City = city,
                    Date = new DateTime(int.Parse(date[0]), int.Parse(date[1]), int.Parse(date[2])),
                    Temp = day.Day.MintempC,
                    UnitTemp = Common.Common.TemperatureUnits[1],
                    WindSpeed = day.Day.MaxwindMph,
                    UnitWind = Common.Common.WindUnits[0],
                    HasPrecipitation = day.Day.TotalprecipIn > 0 ? true : false,
                    Humidity = day.Day.Avghumidity,
                    Icon = ConvertIconToBytes(day.Day.Condition.Icon.ToString()),
                });
            }
            return result;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public List<City> GetAllCitiesByCity(string parameter)
    {
        try
        {
            var cities = httpClient
                .GetFromJsonAsync<List<Model.WeatherApiCity.Root>?>
                ($"http://api.weatherapi.com/v1/search.json?key={apiKey}&q={parameter}")
                .Result;
            if (cities.Count == 0)
                throw new Exception("There are no cities");
            List<City> result = new();
            foreach (var city in cities)
                result.Add(new City()
                {
                    CityName = city.Name,
                    Country = city.Country,
                    AdministrativeArea = city.Region,
                    Latitude = city.Lat.ToString(),
                    Longitude = city.Lon.ToString(),
                });
            return result;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    private byte[] ConvertIconToBytes(string iconUrl)
    {
        try
        {
            return httpClient
                .GetAsync($"https:{iconUrl}").Result
                .Content
                .ReadAsByteArrayAsync().Result;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
