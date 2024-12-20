
namespace FileTransferService.Services
{
    public interface ILoggerService
    {
        void LogInformation(string message);
        void LogError(string message, Exception? exception = null);
        void LogWarning(string message);
    }
}
