using FileTransferService.Services;

namespace FileTransferService
{
    public class FileTransferWorker : BackgroundService
    {
        private readonly ILoggerService _logger;
        private readonly ITransferService _transferService;
        private readonly IConfigService _configService;
        private string _sourceFolder = "C:\\TEMP\\T1";
        private string _destinationFolder = "C:\\TEMP\\T2";
        private readonly TimeSpan _pollingInterval = TimeSpan.FromSeconds(10);

        public FileTransferWorker(ILoggerService logger, ITransferService transferService, IConfigService configService)
        {
            _logger = logger;
            _transferService = transferService;
            _configService = configService;
        }

        private async Task GetConfiguration()
        {
            var config = await _configService.GetConfig();
            if (!config.IsValid)
            {
                _logger.LogError($"{DateTime.Now} Invalid configuration. Using default values.\nSource folder:{_sourceFolder}\nDestination folder:{_destinationFolder}");
                return;
            }
            _destinationFolder = config.Destination;
            _sourceFolder = config.Source;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation($"{DateTime.Now} File Transfer Service is starting.");

            if (!Directory.Exists(_sourceFolder))
            {
                Directory.CreateDirectory(_sourceFolder);
                _logger.LogInformation($"{DateTime.Now} Source folder created: {_sourceFolder}");
            }

            if (!Directory.Exists(_destinationFolder))
            {
                Directory.CreateDirectory(_destinationFolder);
                _logger.LogInformation($"{DateTime.Now} Destination folder created: {_destinationFolder}");
            }

            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    var files = Directory.GetFiles(_sourceFolder, "*.txt");
                    await GetConfiguration();
                    _transferService.TransferFiles(_sourceFolder, _destinationFolder);
                }
                catch (Exception ex)
                {
                    _logger.LogError($"{DateTime.Now} An error occurred while processing files.", ex);
                }

                await Task.Delay(_pollingInterval, stoppingToken);
            }

            _logger.LogInformation($"{DateTime.Now} File Transfer Service is stopping.");
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation($"{DateTime.Now} Service is starting.");
            return base.StartAsync(cancellationToken);
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation($"{DateTime.Now} Service is stopping.");
            return base.StopAsync(cancellationToken);
        }
    }
}
