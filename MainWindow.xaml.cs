// MainWindow.xaml.cs
using System.Windows;
using Serilog;

namespace ArchiveSystem;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        Log.Information("Главное окно создано");
    }

    private void TestButton_Click(object sender, RoutedEventArgs e)
    {
        Log.Information("Нажата кнопка тестирования");
        StatusText.Text = "Логи записаны! Проверьте папку logs/";

        // Тестируем логирование
        Log.Debug("Debug сообщение");
        Log.Warning("Warning сообщение");
        Log.Error("Error сообщение");
    }
}