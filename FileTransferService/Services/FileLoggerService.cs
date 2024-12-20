using Serilog;

namespace FileTransferService.Services
{
    public class FileLoggerService : ILoggerService
    {
        private readonly Serilog.ILogger _logger;
        private readonly string _logsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "AJKFileTransferService", "logs");

        public FileLoggerService()
        {
            Directory.CreateDirectory(_logsPath);

            _logger = new LoggerConfiguration()
                .WriteTo.File(Path.Combine(_logsPath, "AJKFileTransferServiceLog.txt"), rollingInterval: RollingInterval.Day, retainedFileCountLimit: 7)
                .CreateLogger();
        }

        public void LogInformation(string message)
        {
            _logger.Information(message);
        }

        public void LogError(string message, Exception? exception = null)
        {
            _logger.Error(exception, message);
        }

        public void LogWarning(string message)
        {
            _logger.Warning(message);
        }
    }
}
