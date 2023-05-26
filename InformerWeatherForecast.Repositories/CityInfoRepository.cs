using InformerWeatherForecast.DAL;
using InformerWeatherForecast.Model.SqliteDB;
using Microsoft.EntityFrameworkCore;
using InformerWeatherForecast.Common.RepositoryInterfaces;

namespace InformerWeatherForecast.Repositories;

public class CityInfoRepository : ICityInfoRepository
{
    private readonly ApplicationContext db;

    public CityInfoRepository(ApplicationContext db)
    {
        this.db = db;
    }


    public CityInfo? Add(CityInfo cityInfo)
    {
        CityInfo? result;
        try
        {
            result = db.CityInfos.Add(cityInfo).Entity;
            db.SaveChanges();
        }
        catch (Exception)
        {
            result = null;
        }
        return result;
    }

    public bool AddActive(int Id)
    {
        bool result;
        List<CityInfo> cityInfos = new List<CityInfo>();
        try
        {
            cityInfos = GetAll();
            foreach (CityInfo cityinfo in cityInfos)
            {
                 if(cityinfo.Id==Id)
                    cityinfo.IsActive = true;
                 else cityinfo.IsActive = false;
                 db.Update(cityinfo);
            }
            db.SaveChanges();   
            result = true;
        }
        catch (Exception)
        {
            result = false;
        }
        return result;
    }


    public bool Exists(CityInfo cityInfo)
    {
       return db.CityInfos.Where(c => c.CityName == cityInfo.CityName)
                          .Where(c => c.Country == cityInfo.Country)
                          .Where(c => c.AdministrativeArea == cityInfo.AdministrativeArea).Any();
    }

    public List<CityInfo> GetAll()
    {
        return db.CityInfos.ToList();
    }

    public CityInfo? GetCityInfoById(int id)
    {
        return db.CityInfos.Find(id);
    }
}