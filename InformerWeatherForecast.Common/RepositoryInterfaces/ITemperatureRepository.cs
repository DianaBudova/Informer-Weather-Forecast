using InformerWeatherForecast.Model.SqliteDB;

namespace InformerWeatherForecast.Common.RepositoryInterfaces;

public interface ITemperatureRepository
{
    bool AddRange(List<Temperature> list);
    List<Temperature> GetAll();
    Temperature? GetById(int id);
}
