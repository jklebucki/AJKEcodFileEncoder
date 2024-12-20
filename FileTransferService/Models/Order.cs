namespace FileTransferService.Models
{
    internal class Order
    {
        internal DocumentOrder DocumentOrderItem { get; set; } = new DocumentOrder();
        internal FileRow FileRowItem { get; set; } = new FileRow();
    }
}
