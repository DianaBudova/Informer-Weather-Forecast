using InformerWeatherForecast.DAL;
using InformerWeatherForecast.Model.SqliteDB;
using Microsoft.EntityFrameworkCore;
using InformerWeatherForecast.Common.RepositoryInterfaces;

namespace InformerWeatherForecast.Repositories;

public  class ProviderRepository:IProviderRepository
{
    private readonly ApplicationContext db;

    public ProviderRepository(ApplicationContext db)
    {
        this.db = db;
    }

    public bool AddRange(List<Provider> list)
    {
        bool result;
        try
        {
            db.Providers.AddRange(list);
            db.SaveChanges();
            result = true;
        }
        catch (DbUpdateException)
        {
            result = false;
        }
        return result;
    }

    public List<Provider> GetAll()
    {
        return db.Providers.ToList();
    }

    public Provider? GetById(int id)
    {
        return db.Providers.Find(id);
    }
}
