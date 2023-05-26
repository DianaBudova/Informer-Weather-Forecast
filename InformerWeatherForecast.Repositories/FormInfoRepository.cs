using InformerWeatherForecast.DAL;
using InformerWeatherForecast.Model.SqliteDB;
using InformerWeatherForecast.Common.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;


namespace InformerWeatherForecast.Repositories;

    public class FormInfoRepository : IFormInfoRepository
    {
        private readonly ApplicationContext db;

        public FormInfoRepository(ApplicationContext db)
        {
            this.db = db;
        }

        public FormInfo? Add(FormInfo formInfo)
        {
            FormInfo? result;
            try
            {
                result = db.FormInfos.Add(formInfo).Entity;
                db.SaveChanges();
            }
            catch (Exception)
            {
                result = null;
            }
            return result;
        }

        public FormInfo? GetFormInfoById(int id)
        {
            return db.FormInfos.Find(id);
        }

    public bool Update(FormInfo formInfo)
    {
        db.Update(formInfo);
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

}

