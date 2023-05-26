using InformerWeatherForecast.Model.SqliteDB;

namespace InformerWeatherForecast.Common.RepositoryInterfaces;

public interface IPressureRepository
{
    bool AddRange(List<Pressure> list);
    List<Pressure> GetAll();
    Pressure? GetById(int id);
}
