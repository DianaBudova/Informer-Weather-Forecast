using InformerWeatherForecast.Common.RepositoryInterfaces;
using InformerWeatherForecast.Model.SqliteDB;
using InformerWeatherForecast.Common;
using InformerWeatherForecast.BL;
using Microsoft.Extensions.DependencyInjection;
using ApplicationContext = InformerWeatherForecast.DAL.ApplicationContext;
using InformerWeatherForecast.Repositories;
using InformerWeatherForecast.APIConnector;
using InformerWeatherForecast.Model.Common;
using Microsoft.Web.WebView2.WinForms;
using Timer = System.Windows.Forms.Timer;

namespace InformerWeatherForecast.UIDesktop
{
    public partial class MainForm : Form
    {
        private Controller controller;

        private Configuration? configuration;
        //private FormInfo? formInfo;
        private CityInfo? currentCityInfo;
        private Temperature? currentUnitTemp;
        private Pressure? currentUnitPressure;
        private Provider? currentNameProvider;
        private Wind? currentUnitWind;
        private Map? currentNameMap;
        private CountOfDay? currentForecastDay;
        private WeatherInfo? currentWeatherInfo;

        private string usingUnitTemp;
        private string usingUnitWind;
        private string usingUnitPressure;
        List<WeatherInfo>? weather;
        Timer timer;
        private int totalDays;
        City? chosenCity;
        private WebView2 webView = new();

        public MainForm()
        {
            InitializeComponent();
            SetController(APIFactory.GetAccuWeatherAPI());
            this.webView.Parent = this.tableLayoutPanel10;
            this.webView.Size = new Size(500, 500);
            weather = new();
            timer = new();
            timer.Interval = 900000;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            GetAndShowWeather();
        }

        private void btnAllCurWeather_Click(object sender, EventArgs e)
        {
            if (this.currentWeatherInfo is not null)
                new MoreInfoWeatherForm(this.currentWeatherInfo).ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ApplicationContext db = new ApplicationContext();
            //db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
            SetDefaultParameters();
            LoadingParametersInForm();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.SaveFormInfoToDB(this.controller.DatabaseMediator.GetFormInfoById(1));
            this.SaveConfigurationToDB();
            this.SaveCityInfoToDB();
        }

        private void SetDefaultParameters()
        {
            var formInfo = this.controller.DatabaseMediator.GetFormInfoById(1);
            if (formInfo != null)
            {
                this.Location = new Point(formInfo.Position_X, formInfo.Position_Y);
                this.Size = new Size(formInfo.Size_X, formInfo.Size_Y);
            }
            else
            {
                this.Location = new Point(100, 100);
                this.Size = new Size(1338, 804);
            }

            var temperatures = this.controller.DatabaseMediator.GetAllTemperatures();
            if (temperatures?.Count == 0)
            {
                foreach (var value in Common.Common.TemperatureUnits)
                    temperatures.Add(new() { Unit = value });
                this.controller.DatabaseMediator.AddTemperatureRange(temperatures);
                this.currentUnitTemp = this.controller.DatabaseMediator.GetTemperatureById(1);
            }

            var winds = this.controller.DatabaseMediator.GetAllWinds();
            if (winds?.Count == 0)
            {
                foreach (var value in Common.Common.WindUnits)
                    winds.Add(new() { Unit = value });
                this.controller.DatabaseMediator.AddWindRange(winds);
                this.currentUnitWind = this.controller.DatabaseMediator.GetWindById(1);
            }

            var countOfDays = this.controller.DatabaseMediator.GetAllCountOfDays();
            if (countOfDays?.Count == 0)
            {
                foreach (var value in Common.Common.Days)
                    countOfDays.Add(new() { Count = int.Parse(value) });
                this.controller.DatabaseMediator.AddCountOfDaysRange(countOfDays);
                this.currentForecastDay = this.controller.DatabaseMediator.GetCountOfDaysById(1);
            }

            var pressures = this.controller.DatabaseMediator.GetAllPressures();
            if (pressures?.Count == 0)
            {
                foreach (var value in Common.Common.PressureUnits)
                    pressures.Add(new() { Unit = value });
                this.controller.DatabaseMediator.AddPressureRange(pressures);
                this.currentUnitPressure = this.controller.DatabaseMediator.GetPressureById(1);
            }

            var providers = this.controller.DatabaseMediator.GetAllProviders();
            if (providers.Count == 0)
            {
                foreach (var value in Common.Common.APIProviders)
                    providers.Add(new() { Name = value });
                this.controller.DatabaseMediator.AddProviderRange(providers);
                this.currentNameProvider = this.controller.DatabaseMediator.GetProviderById(1);
            }

            configuration = this.controller.DatabaseMediator.GetConfigurationById(1);
            if (configuration == null)
            {
                configuration = new Configuration() { PressureId = 1, ProviderId = 1, TemperatureId = 2, WindId = 2, CountOfDaysId = 1, MapId = 1 };
                this.controller.DatabaseMediator.AddConfiguration(configuration);
                this.configuration = this.controller.DatabaseMediator.GetConfigurationById(1);
            }

            var maps = this.controller.DatabaseMediator.GetAllMaps();
            if (maps?.Count == 0)
            {
                foreach (var value in Common.Common.Maps)
                    maps.Add(new() { Name = value });
                this.controller.DatabaseMediator.AddMapRange(maps);
                this.currentNameMap = this.controller.DatabaseMediator.GetMapById(1);
            }
        }

        private void LoadingParametersInForm()
        {
            LoadTemperaturesInForm();
            LoadPressuresInForm();
            LoadSpeedWindInForm();
            LoadCitiesInForm();
            LoadApiInForm();
            LoadIpAddressesInForm();
            LoadMapsInForm();
        }

        private void LoadTemperaturesInForm()
        {
            cmbBTempIn.DataSource = this.controller.DatabaseMediator.GetAllTemperatures();
            cmbBTempIn.DisplayMember = nameof(Temperature.Unit);
            cmbBTempIn.ValueMember = "Id";
            cmbBTempIn.SelectedIndex = this.configuration!.TemperatureId - 1;
        }

        private void LoadPressuresInForm()
        {
            combBPressure.DataSource = this.controller.DatabaseMediator.GetAllPressures();
            combBPressure.DisplayMember = nameof(Pressure.Unit);
            combBPressure.ValueMember = "Id";
            combBPressure.SelectedIndex = this.configuration!.PressureId - 1;
        }

        private void LoadSpeedWindInForm()
        {
            combBSpeedWind.DataSource = this.controller.DatabaseMediator.GetAllWinds();
            combBSpeedWind.DisplayMember = nameof(Wind.Unit);
            combBSpeedWind.ValueMember = "Id";
            combBSpeedWind.SelectedIndex = this.configuration!.WindId - 1;
        }

        private void LoadCitiesInForm()
        {
            combBCity.DataSource = this.controller.DatabaseMediator.GetAllCitiesInfo();
            combBCity.DisplayMember = nameof(CityInfo.CityName);
            combBCity.ValueMember = "Id";
            if (this.controller.DatabaseMediator.GetAllCitiesInfo().Count != 0)
                combBCity.SelectedIndex = this.controller.DatabaseMediator.GetAllCitiesInfo().Where(e => e.IsActive == true).First().Id - 1;
        }

        private void LoadApiInForm()
        {
            comboBApi.DataSource = this.controller.DatabaseMediator.GetAllProviders();
            comboBApi.DisplayMember = nameof(Provider.Name);
            comboBApi.ValueMember = "Id";
            comboBApi.SelectedIndex = this.configuration!.ProviderId - 1;
        }

        private void LoadIpAddressesInForm()
        {
            combBIpAddress.DataSource = this.controller.DatabaseMediator.GetAllCountOfDays();
            combBIpAddress.DisplayMember = nameof(CountOfDay.Count);
            combBIpAddress.ValueMember = "Id";
            combBIpAddress.SelectedIndex = this.configuration!.CountOfDaysId - 1;
        }

        private void LoadMapsInForm()
        {
            combMapOn.DataSource = this.controller.DatabaseMediator.GetAllMaps();
            combMapOn.DisplayMember = nameof(Map.Name);
            combMapOn.ValueMember = "Id";
            combMapOn.SelectedIndex = this.configuration!.MapId - 1;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                timer.Stop();
                string parameter = this.combBCity.Text;
                if (parameter == "")
                    throw new Exception("There is no any inputed city");
                var cities = this.controller.APIConnectorMediator.GetAllCitiesByCityName(parameter);
                if (cities.Count == 0)
                    throw new Exception("There are no cities with inputed city name");
                if (this.comboBApi.Text == Common.Common.APIProviders[0])
                    SetController(APIFactory.GetAccuWeatherAPI());
                else
                    SetController(APIFactory.GetWeatherApiAPI());
                chosenCity = this.OpenChooseCityForm(cities);
                this.combBCity.Text = chosenCity.CityName;
                totalDays = this.currentForecastDay!.Count;
                GetAndShowWeather();
                this.usingUnitTemp = weather.First().UnitTemp;
                this.usingUnitPressure = weather.First().UnitPressure;
                this.usingUnitWind = weather.First().UnitWind;
                var allCities = this.controller.DatabaseMediator.GetAllCitiesInfo();
                int id = 0;
                foreach (var city in allCities)
                    if (city.CityName == this.combBCity.Text)
                        id = city.Id;
                if (id == 0)
                    id = this.controller.DatabaseMediator.GetAllCitiesInfo().Count + 1;
                this.currentCityInfo = new()
                {
                    Id = id,
                    CityName = chosenCity.CityName,
                    AdministrativeArea = chosenCity.AdministrativeArea,
                    Country = chosenCity.Country,
                    Latitude = double.Parse(chosenCity.Latitude),
                    Longitude = double.Parse(chosenCity.Longitude),
                    IsActive = true,
                };
                this.currentWeatherInfo = weather.FirstOrDefault();
                this.SaveCityInfoToDB();
                this.LoadCitiesInForm();
                timer.Interval = 900000;
                timer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbBTempIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentUnitTemp = cmbBTempIn.SelectedItem as Temperature;
            if (this.labTempCur.Text == "")
                return;
            string changed = "";
            if (this.usingUnitTemp == Common.Common.TemperatureUnits[0])
            {
                if (currentUnitTemp.Unit == Common.Common.TemperatureUnits[1])
                    changed = Common.Common.FromFahrenheitToCelsius(double.Parse(this.labTempCur.Text)).ToString();
                if (currentUnitTemp.Unit == Common.Common.TemperatureUnits[2])
                    changed = Common.Common.FromFahrenheitToKelvin(double.Parse(this.labTempCur.Text)).ToString();
            }
            if (this.usingUnitTemp == Common.Common.TemperatureUnits[1])
            {
                if (currentUnitTemp.Unit == Common.Common.TemperatureUnits[0])
                    changed = Common.Common.FromCelsiusToFahrenheit(double.Parse(this.labTempCur.Text)).ToString();
                if (currentUnitTemp.Unit == Common.Common.TemperatureUnits[2])
                    changed = Common.Common.FromCelsiusToKelvin(double.Parse(this.labTempCur.Text)).ToString();
            }
            if (this.usingUnitTemp == Common.Common.TemperatureUnits[2])
            {
                if (currentUnitTemp.Unit == Common.Common.TemperatureUnits[0])
                    changed = Common.Common.FromKelvinToFahrenheit(double.Parse(this.labTempCur.Text)).ToString();
                if (currentUnitTemp.Unit == Common.Common.TemperatureUnits[1])
                    changed = Common.Common.FromKelvinToCelsius(double.Parse(this.labTempCur.Text)).ToString();
            }
            if (changed == "")
                return;
            this.usingUnitTemp = currentUnitTemp.Unit;
            this.labTempCur.Text = changed;
        }

        private void combBSpeedWind_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentUnitWind = combBSpeedWind.SelectedItem as Wind;
            if (this.labSpeedWind.Text == "")
                return;
            string changed = "";
            if (this.usingUnitWind == Common.Common.WindUnits[0])
            {
                if (currentUnitWind.Unit == Common.Common.WindUnits[1])
                    changed = Common.Common.FromMphToMs(double.Parse(this.labSpeedWind.Text)).ToString();
                if (currentUnitWind.Unit == Common.Common.WindUnits[2])
                    changed = Common.Common.FromMphToKph(double.Parse(this.labSpeedWind.Text)).ToString();
            }
            if (this.usingUnitWind == Common.Common.WindUnits[1])
            {
                if (currentUnitWind.Unit == Common.Common.WindUnits[0])
                    changed = Common.Common.FromMsToMph(double.Parse(this.labSpeedWind.Text)).ToString();
                if (currentUnitWind.Unit == Common.Common.WindUnits[2])
                    changed = Common.Common.FromMsToKph(double.Parse(this.labSpeedWind.Text)).ToString();
            }
            if (this.usingUnitWind == Common.Common.WindUnits[2])
            {
                if (currentUnitWind.Unit == Common.Common.WindUnits[0])
                    changed = Common.Common.FromKphToMph(double.Parse(this.labSpeedWind.Text)).ToString();
                if (currentUnitWind.Unit == Common.Common.WindUnits[1])
                    changed = Common.Common.FromKphToMs(double.Parse(this.labSpeedWind.Text)).ToString();
            }
            if (changed == "")
                return;
            this.usingUnitWind = currentUnitWind.Unit;
            this.labSpeedWind.Text = changed;
        }

        private void combBPressure_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentUnitPressure = combBPressure.SelectedItem as Pressure;
            if (this.labelPressure.Text == "")
                return;
            string changed = "";
            if (this.usingUnitPressure == Common.Common.PressureUnits[0])
            {
                if (currentUnitPressure.Unit == Common.Common.PressureUnits[1])
                    changed = Common.Common.FromPascalToBar(double.Parse(this.labelPressure.Text)).ToString();
            }
            if (this.usingUnitPressure == Common.Common.PressureUnits[1])
            {
                if (currentUnitPressure.Unit == Common.Common.PressureUnits[0])
                    changed = Common.Common.FromBarToPascal(double.Parse(this.labelPressure.Text)).ToString();
            }
            if (changed == "")
                return;
            this.usingUnitPressure = currentUnitPressure.Unit;
            this.labelPressure.Text = changed;
        }

        private void comboBApi_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentNameProvider = comboBApi.SelectedItem as Provider;
        }

        private void combBCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentCityInfo = combBCity.SelectedItem as CityInfo;
        }

        private void combBIpAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentForecastDay = combBIpAddress.SelectedItem as CountOfDay;
        }

        private void combMapOn_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentNameMap = combMapOn.SelectedItem as Map;
            if (this.currentCityInfo is null)
                return;
            if (currentNameMap.Name == Common.Common.Maps[0])
                this.webView.Source = new($"https://www.ventusky.com/?p={this.currentCityInfo.Latitude.ToString().Replace(',', '.')};{this.currentCityInfo.Longitude.ToString().Replace(',', '.')};4&l=clouds-total");
            if (currentNameMap.Name == Common.Common.Maps[1])
                this.webView.Source = new($"https://www.ventusky.com/?p={this.currentCityInfo.Latitude.ToString().Replace(',', '.')};{this.currentCityInfo.Longitude.ToString().Replace(',', '.')};4&l=rain-3h");
            if (currentNameMap.Name == Common.Common.Maps[2])
                this.webView.Source = new($"https://www.ventusky.com/?p={this.currentCityInfo.Latitude.ToString().Replace(',', '.')};{this.currentCityInfo.Longitude.ToString().Replace(',', '.')};4&l=temperature-2m");
            if (currentNameMap.Name == Common.Common.Maps[3])
                this.webView.Source = new($"https://www.ventusky.com/?p={this.currentCityInfo.Latitude.ToString().Replace(',', '.')};{this.currentCityInfo.Longitude.ToString().Replace(',', '.')};4&l=wind-10m");
            if (currentNameMap.Name == Common.Common.Maps[4])
                this.webView.Source = new($"https://www.ventusky.com/?p={this.currentCityInfo.Latitude.ToString().Replace(',', '.')};{this.currentCityInfo.Longitude.ToString().Replace(',', '.')};4&l=humidity");
            if (currentNameMap.Name == Common.Common.Maps[5])
                this.webView.Source = new($"https://www.ventusky.com/?p={this.currentCityInfo.Latitude.ToString().Replace(',', '.')};{this.currentCityInfo.Longitude.ToString().Replace(',', '.')};4&l=snow");
        }

        private void SetController(ICommonAPI api)
        {
            var temp = new ServiceCollection()
                .AddDbContext<ApplicationContext>()
                .AddScoped<ICityInfoRepository, CityInfoRepository>()
                .AddScoped<IConfigurationRepository, ConfigurationRepository>()
                .AddScoped<IPressureRepository, PressureRepository>()
                .AddScoped<IProviderRepository, ProviderRepository>()
                .AddScoped<ITemperatureRepository, TemperatureRepository>()
                .AddScoped<IWindRepository, WindRepository>()
                .AddScoped<IFormInfoRepository, FormInfoRepository>()
                .AddScoped<ICountOfDaysRepository, CountOfDaysRepository>()
                .AddScoped<IMapRepository, MapRepository>();
            if (api.GetType() == APIFactory.GetAccuWeatherAPI().GetType())
                temp.AddScoped<ICommonAPI, AccuWeatherAPI>();
            if (api.GetType() == APIFactory.GetWeatherApiAPI().GetType())
                temp.AddScoped<ICommonAPI, WeatherApiAPI>();
            var serviceCollection = temp
                .AddSingleton<APIConnectorMediator>()
                .AddSingleton<DatabaseMediator>()
                .BuildServiceProvider();
            this.controller = new(serviceCollection.GetRequiredService<APIConnectorMediator>(), serviceCollection.GetRequiredService<DatabaseMediator>());
        }

        private void ConfigureUnitsByCurrentWeather(WeatherInfo weather)
        {
            for (int i = 0; i < Common.Common.TemperatureUnits.Count(); i++)
                if (weather.UnitTemp == Common.Common.TemperatureUnits[i])
                    this.cmbBTempIn.SelectedIndex = i;
            for (int i = 0; i < Common.Common.PressureUnits.Count(); i++)
                if (weather.UnitPressure == Common.Common.PressureUnits[i])
                    this.combBPressure.SelectedIndex = i;
            for (int i = 0; i < Common.Common.WindUnits.Count(); i++)
                if (weather.UnitWind == Common.Common.WindUnits[i])
                    this.combBSpeedWind.SelectedIndex = i;
        }

        private void ConfigureFormByCurrentWeather(WeatherInfo weather)
        {
            this.picBCurWeatherImg.Image = (Bitmap)(new ImageConverter()).ConvertFrom(weather.Icon)!;
            this.labTempCur.Text = $"{(weather.Temp == 0 ? "" : weather.Temp > 0 ? "+" : "-")}{weather.Temp}";
            this.labSpeedWind.Text = $"{weather.WindSpeed}";
            this.labelPressure.Text = $"{weather.Pressure}";
            this.labHumidity.Text = $"{weather.Humidity} %";
            this.labCloud.Text = $"{weather.Clouds}";
        }

        private void ConfigureFormByWeatherForecast(List<WeatherInfo> forecast)
        {
            ImageList images = new();
            for (int i = 0; i < forecast.Count; i++)
                images.Images.Add((Bitmap)(new ImageConverter()).ConvertFrom(forecast.ElementAt(i).Icon)!);
            foreach (var day in forecast)
            {
                ListViewItem item = new(day.Date.ToString().Split()[0]);
                item.SubItems.Add($"{day.Temp} {day.UnitTemp}");
                item.SubItems.Add($"{day.WindSpeed} {day.UnitWind}");
                item.SubItems.Add($"{day.WindDirectionLocalized}");
                item.SubItems.Add($"{day.Clouds}");
                item.SubItems.Add($"{day.Humidity} %");
                item.SubItems.Add($"{day.Pressure} {day.UnitPressure}");
                this.lstVwWeather.Items.Add(item);
            }
        }

        private City? OpenChooseCityForm(List<City> cities)
        {
            try
            {
                if (cities.Count == 1)
                    return cities.FirstOrDefault();
                ChooseCity form = new(cities);
                form.ShowDialog();
                if (form.ChosenCity is null)
                    throw new Exception("There is no chosen city");
                return form.ChosenCity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void SaveFormInfoToDB(FormInfo? formInfo)
        {
            if (formInfo == null)
                this.controller.DatabaseMediator.AddFormInfo(new FormInfo() { Position_X = this.Location.X, Position_Y = this.Location.Y, Size_X = this.Size.Width, Size_Y = this.Size.Height });
            else
            {
                formInfo.Position_Y = this.Location.Y;
                formInfo.Position_X = this.Location.X;
                formInfo.Size_X = this.Size.Width;
                formInfo.Size_Y = this.Size.Height;
                this.controller.DatabaseMediator.UpdateFormInfo(formInfo);
            }
        }

        private void SaveConfigurationToDB()
        {
            if (this.configuration is null)
                return;
            this.configuration.PressureId = currentUnitPressure!.Id;
            this.configuration.TemperatureId = currentUnitTemp!.Id;
            this.configuration.WindId = currentUnitWind!.Id;
            this.configuration.ProviderId = currentNameProvider!.Id;
            this.configuration.CountOfDaysId = currentForecastDay!.Id;
            this.configuration.MapId = currentNameMap!.Id;
            this.controller.DatabaseMediator.UpdateConfiguration(this.configuration);
        }

        private void SaveCityInfoToDB()
        {
            if (this.currentCityInfo is null)
                return;
            var cities = this.controller.DatabaseMediator.GetAllCitiesInfo();
            bool cityExistsInDB = false;
            foreach (var city in cities)
            {
                if (city.Latitude == this.currentCityInfo.Latitude &&
                    city.Longitude == this.currentCityInfo.Longitude)
                    cityExistsInDB = true;
            }
            if (!cityExistsInDB)
                this.controller.DatabaseMediator.AddCityInfo(this.currentCityInfo);
            this.controller.DatabaseMediator.ActiveCityInfoById(this.currentCityInfo.Id);
        }

        private void GetAndShowWeather()
        {
            this.lstVwWeather.Items.Clear();
            weather!.Clear();
            //MessageBox.Show("Загружаем/Обновляем данные");
            if (totalDays == 1)
                weather.Add(this.controller.APIConnectorMediator.GetCurrentWeatherByCity(chosenCity!));
            else
                weather.AddRange(this.controller.APIConnectorMediator.GetWeatherFiveDaysByCity(chosenCity!));
            this.ConfigureUnitsByCurrentWeather(weather.First());
            this.ConfigureFormByCurrentWeather(weather.First());
            if (weather.Count > 1)
                this.ConfigureFormByWeatherForecast(weather);
        }
    }
}