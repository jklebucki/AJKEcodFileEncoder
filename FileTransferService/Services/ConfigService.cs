
using FileTransferService.Models;
using System.Text.Json;

namespace FileTransferService.Services
{
    public class ConfigService : IConfigService
    {
        private readonly string _appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "AJKFileTransferService");
        private readonly ILoggerService _logger;

        public ConfigService(ILoggerService logger)
        {
            _logger = logger;
            Directory.CreateDirectory(_appDataPath);
        }
        public async Task<Config> GetConfig()
        {
            try
            {
                using (var file = new StreamReader(Path.Combine(_appDataPath, "Config.json")))
                {
                    var json = await file.ReadToEndAsync();
                    var config = JsonSerializer.Deserialize<Config>(json);
                    if (config == null)
                    {
                        _logger.LogError("Error reading config file: Config is null");
                        return new Config { IsValid = false };
                    }
                    return config;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Error reading config file: " + ex.Message);
                return new Config { IsValid = false };
            }
        }

    }
}
