using FileTransferService.Models;
using System.Globalization;
using System.Xml.Serialization;

namespace FileTransferService.Services
{
    internal class OrderService
    {
        internal DocumentOrder? DeserializeOrder(StreamReader xmlStrem)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(DocumentOrder));
                return (DocumentOrder?)serializer.Deserialize(xmlStrem);
            }
            catch
            {
                return null;
            }
        }

        internal IEnumerable<Order> DeserializeOrders(IEnumerable<FileRow> files)
        {
            var orders = new List<Order>();
            CultureInfo provider = CultureInfo.InvariantCulture;
            foreach (var fileRow in files)
            {
                using (var sr = new StreamReader(fileRow.FileName))
                {
                    var order = DeserializeOrder(sr);
                    if (order != null)
                    {
                        orders.Add(new Order() { DocumentOrderItem = order, FileRowItem = fileRow });
                    }
                }
            }
            var result = orders.Where(o => DateTime.ParseExact(o.DocumentOrderItem.OrderHeader.ExpectedDeliveryDate, "yyyy-MM-dd", provider) > new DateTime(2022, 12, 31)).ToList();
            return result;
        }
    }
}
