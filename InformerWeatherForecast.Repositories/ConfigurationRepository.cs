using InformerWeatherForecast.DAL;
using InformerWeatherForecast.Model.SqliteDB;
using Microsoft.EntityFrameworkCore;
using InformerWeatherForecast.Common.RepositoryInterfaces;

namespace InformerWeatherForecast.Repositories;

public  class ConfigurationRepository:IConfigurationRepository
{
    private readonly ApplicationContext db;

    public ConfigurationRepository(ApplicationContext db)
    {
        this.db = db;
    }

    public Configuration? Add(Configuration configuration)
    {
        List<Configuration> list = new List<Configuration>();
        Configuration? result=null;
        list = GetAll();
        if (list.Count == 0)
        {
            try
            {
                result = db.Configurations.Add(configuration).Entity;
                db.SaveChanges();
            }
            catch (Exception)
            {
                result = null;
            }
            return result;
        }
        else return result;
    }

    public List<Configuration> GetAll()
    {
        return db.Configurations.ToList();
     
    }

    public bool Update(Configuration configuration)
    {
        db.Update(configuration);
        int modifiedCount;
        try
        {
            modifiedCount = db.SaveChanges();
        }
        catch (Exception)
        {
            return false;
        }
        return modifiedCount > 0;

    }

    public Configuration? GetById(int id)
    {
        return db.Configurations.Find(id);

    }

}
