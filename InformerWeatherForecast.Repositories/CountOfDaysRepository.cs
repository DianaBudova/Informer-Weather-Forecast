using InformerWeatherForecast.DAL;
using InformerWeatherForecast.Model.SqliteDB;
using Microsoft.EntityFrameworkCore;
using InformerWeatherForecast.Common.RepositoryInterfaces;

namespace InformerWeatherForecast.Repositories;

public class CountOfDaysRepository : ICountOfDaysRepository
{
    private readonly ApplicationContext db;

    public CountOfDaysRepository(ApplicationContext db)
    {
        this.db = db;
    }

    public bool AddRange(List<CountOfDay> list)
    {
        bool result;
        try
        {
            db.CountOfDays.AddRange(list);
            db.SaveChanges();
            result = true;
        }
        catch (DbUpdateException)
        {
            result = false;
        }
        return result;
    }

    public List<CountOfDay> GetAll()
    {
        return db.CountOfDays.ToList();
    }

    public CountOfDay? GetById(int id)
    {
        return db.CountOfDays.Find(id);
    }
}

