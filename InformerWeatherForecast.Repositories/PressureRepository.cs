using InformerWeatherForecast.DAL;
using InformerWeatherForecast.Model.SqliteDB;
using Microsoft.EntityFrameworkCore;
using InformerWeatherForecast.Common.RepositoryInterfaces;

namespace InformerWeatherForecast.Repositories;

public class PressureRepository : IPressureRepository
{
    private readonly ApplicationContext db;

    public PressureRepository(ApplicationContext db)
    {
        this.db = db;
    }

    public bool AddRange(List<Pressure> list)
    {
        bool result;
        try
        {
            db.Pressures.AddRange(list);
            db.SaveChanges();
            result = true;
        }
        catch (Exception)
        {
            result= false;
        }
        return result;
    }

    public List<Pressure> GetAll()
    {
        return db.Pressures.ToList();
    }

    public Pressure? GetById(int id)
    {
       return db.Pressures.Find(id);
    }
}
