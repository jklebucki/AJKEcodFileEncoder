using FileTransferService.Models;
using System.Text;

namespace FileTransferService.Services
{
    internal class TransferService
    {
        private readonly OrderService _orderService;
        public TransferService()
        {
            _orderService = new OrderService();
        }

        internal IEnumerable<string> ReadFiles(string source)
        {
            var files = Directory.GetFiles(source);

            return files.ToList();

        }

        internal bool MoveFile(string source, string destination)
        {
            try
            {
                var sourceFileName = Path.GetFileName(source).Split(" ");
                var detinationFile = Path.Combine(destination, sourceFileName[0]);
                Encoding utf8WithoutBom = new UTF8Encoding(false);
                SaveFileWithNewEncoding(source, detinationFile, utf8WithoutBom);
                File.Delete(source);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        internal bool SaveFileWithNewEncoding(string source, string destination, Encoding encoding)
        {
            try
            {
                using (var sr = new StreamReader(source))
                {
                    using (var sw = new StreamWriter(destination, false, encoding))
                    {
                        sw.Write(sr.ReadToEnd());
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        internal void TransferFiles(string source, string destination)
        {
            var files = ReadFiles(source);

            var filesView = new List<FileRow>();
            int counter = 0;
            foreach (var file in files)
            {
                filesView.Add(new FileRow() { Lp = ++counter, FileName = file });
            }
            var orders = _orderService.DeserializeOrders(filesView);
            var views = new List<FileRow>();
            foreach (var order in orders)
            {
                views.Add(order.FileRowItem);
            }

            foreach (var view in views)
            {
                MoveFile(view.FileName, destination);
            }
        }
    }
}
