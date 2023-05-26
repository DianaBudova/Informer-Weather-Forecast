namespace InformerWeatherForecast.Model.SqliteDB;

public class Provider
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public override string ToString()
    {
        return $"{Name}";
    }
}
