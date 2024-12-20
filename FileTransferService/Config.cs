using System.Text.Json;

namespace FileTransferService
{
    public class Config
    {
        public string Source { get; set; } = string.Empty;
        public string Destination { get; set; } = string.Empty;
        public bool IsValid { get; set; } = true;

        private static readonly ILogger<Config> _logger = LoggerFactory.Create(builder => builder.AddConsole()).CreateLogger<Config>();

        public static async Task<Config> GetConfig()
        {
            try
            {
                using (var file = new StreamReader(Path.Combine(Directory.GetCurrentDirectory(), "Config.json")))
                {
                    var json = await file.ReadToEndAsync();
                    var config = JsonSerializer.Deserialize<Config>(json);
                    if (config == null)
                    {
                        _logger.LogError("Error reading config file: Config is null");
                        return InvalidConfig();
                    }
                    return config;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Error reading config file: " + ex.Message);
                return InvalidConfig();
            }
        }

        private static Config InvalidConfig()
        {
            return new Config { IsValid = false };
        }
    }
}
