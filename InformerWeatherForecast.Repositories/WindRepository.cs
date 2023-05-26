using InformerWeatherForecast.DAL;
using InformerWeatherForecast.Model.SqliteDB;
using Microsoft.EntityFrameworkCore;
using InformerWeatherForecast.Common.RepositoryInterfaces;

namespace InformerWeatherForecast.Repositories;


public class WindRepository:IWindRepository
{
    private readonly ApplicationContext db;

    public WindRepository(ApplicationContext db)
    {
        this.db = db;
    }

    public bool AddRange(List<Wind> list)
    {
        bool result;
        try
        {
            db.Winds.AddRange(list);
            db.SaveChanges();
            result = true;
        }
        catch (DbUpdateException)
        {
            result = false;
        }
        return result;
    }

    public List<Wind> GetAll()
    {
        return db.Winds.ToList();
    }

    public Wind? GetById(int id)
    {
        return db.Winds.Find(id);
    }
}
