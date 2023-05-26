using InformerWeatherForecast.Model.SqliteDB;

namespace InformerWeatherForecast.Common.RepositoryInterfaces;

public  interface IFormInfoRepository
{
    FormInfo? GetFormInfoById(int id);
    FormInfo? Add(FormInfo formInfo);
    public bool Update(FormInfo formInfo);
}
