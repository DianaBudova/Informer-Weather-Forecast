using InformerWeatherForecast.Model.SqliteDB;

namespace InformerWeatherForecast.Common.RepositoryInterfaces;

public interface IProviderRepository
{
    bool AddRange(List<Provider> list);
    List<Provider> GetAll();
    Provider? GetById(int id);
}
