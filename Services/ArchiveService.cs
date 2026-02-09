// Services/ArchiveService.cs
using Serilog;

namespace ArchiveSystem.Services;

public class ArchiveService
{
	private readonly ILogger _logger;

	public ArchiveService()
	{
		_logger = Log.ForContext<ArchiveService>();
		_logger.Information("ArchiveService создан");
	}

	public string GetTestData()
	{
		_logger.Debug("Получение тестовых данных");
		return "Тестовые данные из сервиса";
	}
}