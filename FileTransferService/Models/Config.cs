namespace FileTransferService.Models
{
    public class Config
    {
        public string Source { get; set; } = string.Empty;
        public string Destination { get; set; } = string.Empty;
        public bool IsValid { get; set; } = true;

    }
}
