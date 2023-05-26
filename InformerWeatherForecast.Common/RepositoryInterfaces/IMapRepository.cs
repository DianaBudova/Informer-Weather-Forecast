using InformerWeatherForecast.Model.SqliteDB;

namespace InformerWeatherForecast.Common.RepositoryInterfaces;

public  interface IMapRepository
{
    bool AddRange(List<Map> list);
    List<Map> GetAll();
    Map? GetById(int id);
}

