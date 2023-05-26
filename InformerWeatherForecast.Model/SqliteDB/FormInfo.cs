namespace InformerWeatherForecast.Model.SqliteDB;

    public class FormInfo
    {
        public int Id { get; set; } 
        public int Position_X { get; set; }
        public int Position_Y { get; set; }
        public int Size_X { get; set;} 
        public int Size_Y { get; set;}

        public override string ToString()
        {
            return $"Position_X:{Position_X,-6}Position_Y:{Position_Y,-10} Sixe_X:{Size_X} Size_Y:{Size_Y}";
        }
    }

