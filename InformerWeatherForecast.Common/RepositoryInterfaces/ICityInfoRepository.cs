using InformerWeatherForecast.Model.SqliteDB;

namespace InformerWeatherForecast.Common.RepositoryInterfaces;

public interface ICityInfoRepository
{
    List<CityInfo> GetAll();
    bool Exists(CityInfo cityInfo);
    CityInfo? GetCityInfoById(int id);
    CityInfo? Add(CityInfo cityInfo);
    bool AddActive(int id);
}
