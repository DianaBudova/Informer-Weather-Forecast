namespace InformerWeatherForecast.BL;

public class Controller
{
    public APIConnectorMediator APIConnectorMediator { get; }
    public DatabaseMediator DatabaseMediator { get; }

    public Controller(APIConnectorMediator connectorMediator, DatabaseMediator databaseMediator)
    {
        this.APIConnectorMediator = connectorMediator;
        this.DatabaseMediator = databaseMediator;
    }
}
