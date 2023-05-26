using InformerWeatherForecast.Model.Common;

namespace InformerWeatherForecast.UIDesktop
{
    public partial class ChooseCity : Form
    {
        public City? ChosenCity { get; private set; }
        private List<City> Cities { get; }

        public ChooseCity(List<City> cities)
        {
            InitializeComponent();
            this.Cities = cities;
            foreach (City city in cities)
                this.listBChooseCity.Items.Add($"City: {city.CityName} Region: {city.AdministrativeArea} Country: {city.Country}");
        }

        private void btnChoose_Click(object sender, EventArgs e) =>
            this.ChosenCity = this.Cities[this.listBChooseCity.SelectedIndex];

        private void btnClose_Click(object sender, EventArgs e) =>
            this.Close();
    }
}
