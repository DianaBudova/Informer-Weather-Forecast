using InformerWeatherForecast.DAL;
using InformerWeatherForecast.Model.SqliteDB;
using Microsoft.EntityFrameworkCore;
using InformerWeatherForecast.Common.RepositoryInterfaces;

namespace InformerWeatherForecast.Repositories;

public  class TemperatureRepository: ITemperatureRepository
{
    private readonly ApplicationContext db;

    public TemperatureRepository(ApplicationContext db)
    {
        this.db = db;
    }

    public bool AddRange(List<Temperature> list)
    {
        bool result;
        try
        {
            db.Temperatures.AddRange(list);
            db.SaveChanges();
            result = true;
        }
        catch (DbUpdateException)
        {
            result = false;
        }
        return result;
    }

    public List<Temperature> GetAll()
    {
        return db.Temperatures.ToList();
    }

    public Temperature? GetById(int id)
    {
        return db.Temperatures.Find(id);

    }
}
