using InformerWeatherForecast.DAL;
using InformerWeatherForecast.Model.SqliteDB;
using InformerWeatherForecast.Common.RepositoryInterfaces;

namespace InformerWeatherForecast.UIConsole;

public class Application
{
    private readonly ICityInfoRepository cityRepo;
    private readonly IConfigurationRepository configRepo;
    private readonly IPressureRepository pressureRepo;
    private readonly IProviderRepository providerRepo;
    private readonly ITemperatureRepository temperatureRepo;
    private readonly IWindRepository windRepo;
    private readonly IFormInfoRepository formRepo;

    public Application(ICityInfoRepository cityRepo, IConfigurationRepository configRepo, IPressureRepository pressureRepo, IProviderRepository providerRepo,
                       ITemperatureRepository temperatureRepo, IWindRepository windRepo, IFormInfoRepository formRepo)
    {
        this.cityRepo = cityRepo;
        this.configRepo = configRepo;
        this.pressureRepo = pressureRepo;
        this.providerRepo = providerRepo;
        this.temperatureRepo = temperatureRepo;
        this.windRepo = windRepo;
        this.formRepo = formRepo;

    }

    public void Run()
    {
        ApplicationContext db = new ApplicationContext();
        // удаляем базу данных если такая существует
        //db.Database.EnsureDeleted();
        // добавляем базу данных если такой нет
        bool res2 = db.Database.EnsureCreated();
        List<Wind> winds = new List<Wind>();
        List<Pressure> pressures = new List<Pressure>();
        List<Provider> providers = new List<Provider>();
        List<Temperature> temperatures = new List<Temperature>();

        if (windRepo.GetAll().Count() == 0)
        {
            Wind wind1 = new Wind() { Unit = "m/s" }; winds.Add(wind1);
            Wind wind2 = new Wind() { Unit = "km/h" }; winds.Add(wind2);
            Wind wind3 = new Wind() { Unit = "miles/h" }; winds.Add(wind3);
            bool res = windRepo.AddRange(winds);
            winds.Clear();
        }

        if (pressureRepo.GetAll().Count() == 0)
        {
            Pressure pres1 = new Pressure() { Unit = "hPa" }; pressures.Add(pres1);
            Pressure pres2 = new Pressure() { Unit = "inHg" }; pressures.Add(pres2);
            bool res = pressureRepo.AddRange(pressures);
            winds.Clear();
        }

        if (temperatureRepo.GetAll().Count() == 0)
        {
            Temperature temp1 = new Temperature() { Unit = "Сelsius" }; temperatures.Add(temp1);
            Temperature temp2 = new Temperature() { Unit = "Fahrenheit" }; temperatures.Add(temp2);
            Temperature temp3 = new Temperature() { Unit = "Kelvin" }; temperatures.Add(temp3);
            bool res = temperatureRepo.AddRange(temperatures);
            temperatures.Clear();
        }

        if (providerRepo.GetAll().Count() == 0)
        {
            Provider prov1 = new Provider() { Name = "OpenWeatherMap" }; providers.Add(prov1);
            Provider prov2 = new Provider() { Name = "Accuweather" }; providers.Add(prov2);
            Provider prov3 = new Provider() { Name = "Weatherbit" }; providers.Add(prov3);
            bool res = providerRepo.AddRange(providers);
            providers.Clear();
        }

        if (configRepo.GetAll().Count() == 0)
        {
            Configuration configuration = new Configuration() { WindId = 1, PressureId = 2, TemperatureId = 1, ProviderId = 2 };
            configRepo.Add(configuration);

        }

        FormInfo? forminfo = formRepo.GetFormInfoById(1);

        if (forminfo == null)
        {
            FormInfo rss = new FormInfo() { Position_X = 100, Position_Y = 100, Size_X = 800, Size_Y = 600 };
            formRepo.Add(rss);
            Console.WriteLine(rss);
        }
        else Console.WriteLine(forminfo);




        //else
        //{
        //    Configuration? configuration = configRepo.GetById(1);
        //    if(configuration != null)
        //    {
        //        configuration.PressureId = 1;
        //        configuration.TemperatureId = 1;
        //        configuration.ProviderId= 1;
        //        configuration.WindId= 1;
        //        bool res = configRepo.Update(configuration);

        //    }
        //}

        // Работа с CityInfo
        //CityInfo cityInfo = new CityInfo() {Country="Ukraine",AdministrativeArea="Dnepropetrovska", CityName="Kryvyi Rih",IsActive=false };
        //CityInfo cityInfo2 = new CityInfo() { Country = "Ukraine", AdministrativeArea = "Hersonska", CityName = "Kryvyi Rih", IsActive = false };
        //CityInfo cityInfo3 = new CityInfo() { Country = "Ukraine", AdministrativeArea = "Kievska", CityName = "Kryvyi Rih", IsActive = false };
        //cityRepo.Add(cityInfo);
        //cityRepo.Add(cityInfo2);
        //cityRepo.Add(cityInfo3);

        //List<CityInfo> list = cityRepo.GetAll();
        //foreach (CityInfo item in list)
        //{
        //    Console.WriteLine(item);
        //}
        //Console.WriteLine("-------------------");

        //cityRepo.AddActive(5);

    }
}
