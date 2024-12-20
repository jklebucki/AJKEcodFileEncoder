using FileTransferService.Services;

namespace FileTransferService
{
    public class FileTransferWorker : BackgroundService
    {
        private readonly ILogger<FileTransferWorker> _logger;
        private string _sourceFolder = "C:\\TEMP\\T1";
        private string _destinationFolder = "C:\\TEMP\\T2";
        private readonly TimeSpan _pollingInterval = TimeSpan.FromSeconds(10);

        public FileTransferWorker(ILogger<FileTransferWorker> logger)
        {
            _logger = logger;
        }

        private async Task GetConfiguration()
        {
            var config = await Config.GetConfig();
            if (!config.IsValid)
            {
                _logger.LogError($"Invalid configuration. Using default values.\nSource folder:{_sourceFolder}\nDestination folder:{_destinationFolder}");
                return;
            }
            _destinationFolder = config.Destination;
            _sourceFolder = config.Source;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("File Transfer Service is starting.");

            if (!Directory.Exists(_sourceFolder))
            {
                Directory.CreateDirectory(_sourceFolder);
                _logger.LogInformation("Source folder created: {SourceFolder}", _sourceFolder);
            }

            if (!Directory.Exists(_destinationFolder))
            {
                Directory.CreateDirectory(_destinationFolder);
                _logger.LogInformation("Destination folder created: {DestinationFolder}", _destinationFolder);
            }

            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    var files = Directory.GetFiles(_sourceFolder, "*.txt");
                    await GetConfiguration();
                    var transferService = new TransferService();
                    transferService.TransferFiles(_sourceFolder, _destinationFolder);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "An error occurred while processing files.");
                }

                await Task.Delay(_pollingInterval, stoppingToken);
            }

            _logger.LogInformation("File Transfer Service is stopping.");
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Service is starting.");
            return base.StartAsync(cancellationToken);
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Service is stopping.");
            return base.StopAsync(cancellationToken);
        }
    }
}
