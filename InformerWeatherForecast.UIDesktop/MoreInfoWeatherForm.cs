using InformerWeatherForecast.Model.Common;

namespace InformerWeatherForecast.UIDesktop
{
    public partial class MoreInfoWeatherForm : Form
    {
        public MoreInfoWeatherForm(WeatherInfo weatherInfo)
        {
            InitializeComponent();
            this.listBWeatherInfo.Items.Clear();
            int numOfProp = typeof(WeatherInfo).GetProperties().Length;
            this.listBWeatherInfo.Items.Add($"City: {weatherInfo.City.CityName}");
            this.listBWeatherInfo.Items.Add($"Region: {weatherInfo.City.AdministrativeArea}");
            this.listBWeatherInfo.Items.Add($"Country: {weatherInfo.City.Country}");
            this.listBWeatherInfo.Items.Add($"Latitude: {weatherInfo.City.Latitude}");
            this.listBWeatherInfo.Items.Add($"Longitude: {weatherInfo.City.Longitude}");
            for (int i = 1; i < numOfProp - 1; i++)
                this.listBWeatherInfo.Items.Add($"{typeof(WeatherInfo).GetProperties()[i].Name}: {weatherInfo.GetType().GetProperty(typeof(WeatherInfo).GetProperties()[i].Name).GetValue(weatherInfo, null)}");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
