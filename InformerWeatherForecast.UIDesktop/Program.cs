namespace InformerWeatherForecast.UIDesktop
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {            
            ApplicationConfiguration.Initialize();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}