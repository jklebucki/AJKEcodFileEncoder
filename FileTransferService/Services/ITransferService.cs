using System.Text;

namespace FileTransferService.Services
{
    public interface ITransferService
    {
        IEnumerable<string> ReadFiles(string source);
        bool MoveFile(string source, string destination);
        bool SaveFileWithNewEncoding(string source, string destination, Encoding encoding);
        void TransferFiles(string source, string destination);
    }
}
