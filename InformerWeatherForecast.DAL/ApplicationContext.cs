using InformerWeatherForecast.Model.SqliteDB;
using Microsoft.EntityFrameworkCore;

namespace InformerWeatherForecast.DAL;


public class ApplicationContext : DbContext
{
    public DbSet<CityInfo> CityInfos { get; set; } = null!;
    public DbSet<Configuration> Configurations { get; set; } = null!;
    public DbSet<Temperature> Temperatures { get; set; } = null!;
    public DbSet<Wind> Winds { get; set; } = null!;
    public DbSet<Pressure> Pressures { get; set; } = null!;
    public DbSet<Provider> Providers { get; set; } = null!;
    public DbSet<FormInfo> FormInfos { get; set; } = null!;
    public DbSet<CountOfDay> CountOfDays { get; set; }=null!;
    public DbSet<Map> Maps { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=diffdata.db");
    }
}
