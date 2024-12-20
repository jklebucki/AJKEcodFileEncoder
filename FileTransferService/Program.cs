using FileTransferService;
using FileTransferService.Services;
using Serilog;
using System.Diagnostics;

public static class Program
{
    public static void Main(string[] args)
    {

        var isWindowsService = !(Debugger.IsAttached || args.Contains("--console"));

        var builder = Host.CreateDefaultBuilder(args)
            .UseSerilog()
            .ConfigureServices((hostContext, services) =>
            {
                services.AddSingleton<ILoggerService, FileLoggerService>();
                services.AddSingleton<ITransferService, TransferService>();
                services.AddSingleton<IConfigService, ConfigService>();
                services.AddHostedService<FileTransferWorker>();
            });

        if (isWindowsService)
        {
            builder.UseWindowsService();
        }

        builder.Build().Run();
    }
}
