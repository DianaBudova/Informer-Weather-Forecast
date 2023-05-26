namespace InformerWeatherForecast.Model.SqliteDB;


public class CityInfo
{
    public int Id { get; set; }
    public string? CityName { get; set; }
    public string? AdministrativeArea { get; set; } 
    public string? Country { get; set; }
    public double ? Latitude { get; set; }
    public double? Longitude { get; set; }
    public bool IsActive { get; set; }

    public override string ToString()
    {
        return $"City:{CityName,-25} AdministrativeArea:{AdministrativeArea,-50} Country:{Country,-15}";
    }
}

