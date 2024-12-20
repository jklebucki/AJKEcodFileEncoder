using AJKEcodFileEncoder.Models;
using System.Text;
using System.Text.Json;

namespace AJKEcodFileEncoder.Services
{
    internal class ConfigService
    {
        private readonly string _appFolder;
        private readonly string _configFileName;
        public ConfigService()
        {
            _appFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "AJKFileTransferService");
            Directory.CreateDirectory(_appFolder);
            _configFileName = "Config.json";
        }

        internal void SaveConfig(Config config)
        {
            var configJson = JsonSerializer.Serialize(config);
            using (var sw = new StreamWriter(Path.Combine(_appFolder, _configFileName), false, Encoding.UTF8))
            {
                sw.Write(configJson);
            };
        }

        internal Config LoadConfig()
        {
            if (!File.Exists(Path.Combine(_appFolder, _configFileName)))
            {
                SaveConfig(new Config());
            }
            using (var sr = new StreamReader(Path.Combine(_appFolder, _configFileName), Encoding.UTF8))
            {
                return JsonSerializer.Deserialize<Config>(sr.ReadToEnd())!;
            };
        }
    }
}
