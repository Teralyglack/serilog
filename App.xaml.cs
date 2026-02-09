// App.xaml.cs
using System.Windows;
using Serilog;

namespace ArchiveSystem;

public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        // Настройка Serilog перед запуском
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console()
            .WriteTo.File("logs/app-.log", rollingInterval: RollingInterval.Day)
            .CreateLogger();

        Log.Information("=== ПРИЛОЖЕНИЕ ЗАПУЩЕНО ===");

        base.OnStartup(e);
    }

    protected override void OnExit(ExitEventArgs e)
    {
        Log.Information("=== ПРИЛОЖЕНИЕ ЗАВЕРШЕНО ===");
        Log.CloseAndFlush();
        base.OnExit(e);
    }
}