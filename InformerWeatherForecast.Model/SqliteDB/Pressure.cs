namespace InformerWeatherForecast.Model.SqliteDB;

public class Pressure
{
    public int Id { get; set; }
    public string? Unit { get; set; }
  
    public override string ToString()
    {
        return $"{Unit}";
    }
}
