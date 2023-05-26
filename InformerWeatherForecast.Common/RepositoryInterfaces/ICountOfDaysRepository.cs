using InformerWeatherForecast.Model.SqliteDB;

namespace InformerWeatherForecast.Common.RepositoryInterfaces;

public  interface ICountOfDaysRepository
{
    bool AddRange(List<CountOfDay> list);
    List<CountOfDay> GetAll();
    CountOfDay? GetById(int id);

}
