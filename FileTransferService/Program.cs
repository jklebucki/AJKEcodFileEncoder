using FileTransferService;
using System.Diagnostics;

public static class Program
{
    public static void Main(string[] args)
    {
        var isWindowsService = !(Debugger.IsAttached || args.Contains("--console"));

        var builder = Host.CreateDefaultBuilder(args)
            .ConfigureServices((hostContext, services) =>
            {
                services.AddHostedService<FileTransferWorker>();
            });

        if (isWindowsService)
        {
            builder.UseWindowsService();
        }

        builder.Build().Run();
    }
}
