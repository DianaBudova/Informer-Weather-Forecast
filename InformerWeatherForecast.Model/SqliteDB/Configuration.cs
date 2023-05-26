namespace InformerWeatherForecast.Model.SqliteDB;

public class Configuration
{
    public int Id { get; set; } 
    public int TemperatureId { get; set; }                 
    public int WindId { get; set; }                              
    public int PressureId { get; set; } 
    public int ProviderId { get; set; }  
    public int CountOfDaysId { get; set; }
    public int MapId { get; set; }
}
