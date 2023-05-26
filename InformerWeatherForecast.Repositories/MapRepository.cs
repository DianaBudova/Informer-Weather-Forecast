using InformerWeatherForecast.DAL;
using InformerWeatherForecast.Model.SqliteDB;
using Microsoft.EntityFrameworkCore;
using InformerWeatherForecast.Common.RepositoryInterfaces;

namespace InformerWeatherForecast.Repositories;

public  class MapRepository: IMapRepository
{
    private readonly ApplicationContext db;

    public MapRepository(ApplicationContext db)
    {
        this.db = db;
    }


    public bool AddRange(List<Map> list)
    {
        bool result;
        try
        {
            db.Maps.AddRange(list);
            db.SaveChanges();
            result = true;
        }
        catch (DbUpdateException)
        {
            result = false;
        }
        return result;
    }


    public List<Map> GetAll()
    {
        return db.Maps.ToList();
    }

    public Map? GetById(int id)
    {
        return db.Maps.Find(id);
    }

}

