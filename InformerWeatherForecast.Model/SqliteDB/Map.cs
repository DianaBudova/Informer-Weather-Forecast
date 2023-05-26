
namespace InformerWeatherForecast.Model.SqliteDB
{
    public class Map
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
