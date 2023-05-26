using InformerWeatherForecast.Model.SqliteDB;

namespace InformerWeatherForecast.Common.RepositoryInterfaces;

public interface IConfigurationRepository
{
    Configuration? Add(Configuration configuration);
    bool Update(Configuration configuration);
    List<Configuration> GetAll();
    Configuration? GetById(int id);
}
