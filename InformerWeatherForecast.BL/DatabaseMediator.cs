using InformerWeatherForecast.Common.RepositoryInterfaces;
using InformerWeatherForecast.Model.SqliteDB;

namespace InformerWeatherForecast.BL;

public class DatabaseMediator
{
    private readonly ICityInfoRepository cityRepo;
    private readonly IConfigurationRepository configRepo;
    private readonly IPressureRepository pressureRepo;
    private readonly IProviderRepository providerRepo;
    private readonly ITemperatureRepository temperatureRepo;
    private readonly IWindRepository windRepo;
    private readonly IFormInfoRepository formRepo;
    private readonly ICountOfDaysRepository countRepo;
    private readonly IMapRepository mapRepo;

    public DatabaseMediator(ICityInfoRepository cityRepo, IConfigurationRepository configRepo, IPressureRepository pressureRepo, IProviderRepository providerRepo,
                           ITemperatureRepository temperatureRepo, IWindRepository windRepo, IFormInfoRepository formRepo, ICountOfDaysRepository countRepo, IMapRepository mapRepo)
    {
        this.cityRepo = cityRepo;
        this.configRepo = configRepo;
        this.pressureRepo = pressureRepo;
        this.providerRepo = providerRepo;
        this.temperatureRepo = temperatureRepo;
        this.windRepo = windRepo;
        this.formRepo = formRepo;
        this.countRepo = countRepo;
        this.mapRepo = mapRepo;

    }

    #region CityRepo
    public CityInfo? AddCityInfo(CityInfo cityInfo) =>
        this.cityRepo.Add(cityInfo);

    public bool ActiveCityInfoById(int id) =>
        this.cityRepo.AddActive(id);

    public CityInfo? GetCityInfoById(int id) =>
        this.cityRepo.GetCityInfoById(id);

    public List<CityInfo> GetAllCitiesInfo() =>
        this.cityRepo.GetAll();

    public bool ExistsCityInfo(CityInfo cityInfo) =>
        this.cityRepo.Exists(cityInfo);
    #endregion

    #region ConfigurationRepo
    public Configuration? AddConfiguration(Configuration configuration) =>
        this.configRepo.Add(configuration);

    public List<Configuration> GetAllConfigurations() =>
        this.configRepo.GetAll();

    public Configuration? GetConfigurationById(int id) =>
        this.configRepo.GetById(id);

    public bool UpdateConfiguration(Configuration configuration) =>
        this.configRepo.Update(configuration);
    #endregion

    #region PressureRepo
    public bool AddPressureRange(List<Pressure> list) =>
        this.pressureRepo.AddRange(list);

    public List<Pressure> GetAllPressures() =>
        this.pressureRepo.GetAll();

    public Pressure? GetPressureById(int id) =>
        this.pressureRepo.GetById(id);
    #endregion

    #region ProviderRepo
    public bool AddProviderRange(List<Provider> list) =>
        this.providerRepo.AddRange(list);

    public List<Provider> GetAllProviders() =>
        this.providerRepo.GetAll();

    public Provider? GetProviderById(int id) =>
        this.providerRepo.GetById(id);
    #endregion

    #region TemperatureRepo
    public bool AddTemperatureRange(List<Temperature> list) =>
        this.temperatureRepo.AddRange(list);

    public List<Temperature> GetAllTemperatures() =>
        this.temperatureRepo.GetAll();

    public Temperature? GetTemperatureById(int id) =>
        this.temperatureRepo.GetById(id);
    #endregion

    #region WindRepo
    public bool AddWindRange(List<Wind> list) =>
        this.windRepo.AddRange(list);

    public List<Wind> GetAllWinds() =>
        this.windRepo.GetAll();

    public Wind? GetWindById(int id) =>
        this.windRepo.GetById(id);
    #endregion

    #region FormRepo
    public FormInfo? AddFormInfo(FormInfo formInfo) =>
        this.formRepo.Add(formInfo);

    public bool UpdateFormInfo(FormInfo formInfo) =>
        this.formRepo.Update(formInfo);

    public FormInfo? GetFormInfoById(int id) =>
        this.formRepo.GetFormInfoById(id);
    #endregion

    #region CountRepo
    public bool AddCountOfDaysRange(List<CountOfDay> list) =>
        this.countRepo.AddRange(list);

    public List<CountOfDay> GetAllCountOfDays() =>
        this.countRepo.GetAll();

    public CountOfDay? GetCountOfDaysById(int id) =>
        this.countRepo.GetById(id);
    #endregion

    #region MapRepo
    public bool AddMapRange(List<Map> list) =>
        this.mapRepo.AddRange(list);

    public List<Map> GetAllMaps() =>
        this.mapRepo.GetAll();

    public Map? GetMapById(int id) =>
        this.mapRepo.GetById(id);
    #endregion
}
