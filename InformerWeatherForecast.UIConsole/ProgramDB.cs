//using InformerWeatherForecast.DAL;
//using InformerWeatherForecast.Repositories;
//using InformerWeatherForecast.Common.RepositoryInterfaces;
//using Microsoft.Extensions.DependencyInjection;

//namespace InformerWeatherForecast.UIConsole;

//internal class ProgramDB
//{
//    static void Main(string[] args)
//    {
//        new ServiceCollection()
//        .AddDbContext<ApplicationContext>()
//        .AddScoped<ICityInfoRepository, CityInfoRepository>()
//        .AddScoped<IConfigurationRepository, ConfigurationRepository>()
//        .AddScoped<IPressureRepository, PressureRepository>()
//        .AddScoped<IProviderRepository, ProviderRepository>()
//        .AddScoped<ITemperatureRepository, TemperatureRepository>()
//        .AddScoped<IWindRepository, WindRepository>()
//        .AddScoped<IFormInfoRepository, FormInfoRepository>()
//        .AddSingleton<Application>()
//        .BuildServiceProvider()
//        .GetRequiredService<Application>()
//        .Run();
//    }
//}
