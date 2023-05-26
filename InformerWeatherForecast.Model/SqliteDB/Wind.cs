namespace InformerWeatherForecast.Model.SqliteDB;

public class Wind
{
    public int Id { get; set; }
    public string? Unit { get; set; }

    public override string ToString()
    {
        return $"{Unit}";
    }
}
