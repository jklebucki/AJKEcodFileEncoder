using FileTransferService.Models;

namespace FileTransferService.Services
{
    public interface IConfigService
    {
        Task<Config> GetConfig();
    }
}
