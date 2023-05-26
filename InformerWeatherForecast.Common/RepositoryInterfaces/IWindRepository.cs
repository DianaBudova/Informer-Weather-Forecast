using InformerWeatherForecast.Model.SqliteDB;

namespace InformerWeatherForecast.Common.RepositoryInterfaces;

public interface IWindRepository
{
    bool AddRange(List<Wind> list);
    List<Wind> GetAll();
    Wind? GetById(int id);
}
