namespace InformerWeatherForecast.Model.SqliteDB;


public class CountOfDay
{
    public int Id { get; set; }
    public int Count { get; set; }

    public override string ToString()
    {
        return $"{Count}";
    }

}

