using System.Xml.Serialization;

namespace FileTransferService.Models
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    [XmlRoot(ElementName = "PaymentTerms")]
    public class PaymentTerms
    {
        [XmlElement(ElementName = "PaymentTermsType")]
        public string PaymentTermsType { get; set; } = string.Empty;
        [XmlElement(ElementName = "PaymentMeans")]
        public string PaymentMeans { get; set; } = string.Empty;
        [XmlElement(ElementName = "PaymentDescription")]
        public string PaymentDescription { get; set; } = string.Empty;
        [XmlElement(ElementName = "Percentage")]
        public string Percentage { get; set; } = string.Empty;
        [XmlElement(ElementName = "PeriodType")]
        public string PeriodType { get; set; } = string.Empty;
        [XmlElement(ElementName = "PeriodsNumber")]
        public string PeriodsNumber { get; set; } = string.Empty;
        [XmlElement(ElementName = "PaymentDate")]
        public string PaymentDate { get; set; } = string.Empty;
    }

    [XmlRoot(ElementName = "Payment")]
    public class Payment
    {
        [XmlElement(ElementName = "PaymentTerms")]
        public PaymentTerms PaymentTerms { get; set; }
    }

    [XmlRoot(ElementName = "DeliveryTerms")]
    public class DeliveryTerms
    {
        [XmlElement(ElementName = "DeliveryTermsCode")]
        public string DeliveryTermsCode { get; set; }
        [XmlElement(ElementName = "DeliveryTermsDescription")]
        public string DeliveryTermsDescription { get; set; }
        [XmlElement(ElementName = "PaymentMethod")]
        public string PaymentMethod { get; set; }
    }

    [XmlRoot(ElementName = "Delivery")]
    public class Delivery
    {
        [XmlElement(ElementName = "DeliveryTerms")]
        public DeliveryTerms DeliveryTerms { get; set; }
    }

    [XmlRoot(ElementName = "Order-Header")]
    public class OrderHeader
    {
        [XmlElement(ElementName = "OrderNumber")]
        public string OrderNumber { get; set; }
        [XmlElement(ElementName = "VendorOrderNumber")]
        public string VendorOrderNumber { get; set; }
        [XmlElement(ElementName = "OrderDate")]
        public string OrderDate { get; set; }
        [XmlElement(ElementName = "OrderTime")]
        public string OrderTime { get; set; }
        [XmlElement(ElementName = "ExpectedDeliveryDate")]
        public string ExpectedDeliveryDate { get; set; }
        [XmlElement(ElementName = "ExpectedDeliveryTime")]
        public string ExpectedDeliveryTime { get; set; }
        [XmlElement(ElementName = "LatestDeliveryDate")]
        public string LatestDeliveryDate { get; set; }
        [XmlElement(ElementName = "LatestDeliveryTime")]
        public string LatestDeliveryTime { get; set; }
        [XmlElement(ElementName = "EarliestDeliveryDate")]
        public string EarliestDeliveryDate { get; set; }
        [XmlElement(ElementName = "EarliestDeliveryTime")]
        public string EarliestDeliveryTime { get; set; }
        [XmlElement(ElementName = "CollectionDate")]
        public string CollectionDate { get; set; }
        [XmlElement(ElementName = "CollectionTime")]
        public string CollectionTime { get; set; }
        [XmlElement(ElementName = "ContractNumber")]
        public string ContractNumber { get; set; }
        [XmlElement(ElementName = "ContractDate")]
        public string ContractDate { get; set; }
        [XmlElement(ElementName = "DocumentExpirationDate")]
        public string DocumentExpirationDate { get; set; }
        [XmlElement(ElementName = "PromotionReference")]
        public string PromotionReference { get; set; }
        [XmlElement(ElementName = "DocumentFunctionCode")]
        public string DocumentFunctionCode { get; set; }
        [XmlElement(ElementName = "MessageType")]
        public string MessageType { get; set; }
        [XmlElement(ElementName = "Remarks")]
        public string Remarks { get; set; }
        [XmlElement(ElementName = "OrderCurrency")]
        public string OrderCurrency { get; set; }
        [XmlElement(ElementName = "Payment")]
        public Payment Payment { get; set; }
        [XmlElement(ElementName = "Delivery")]
        public Delivery Delivery { get; set; }
    }

    [XmlRoot(ElementName = "Buyer")]
    public class Buyer
    {
        [XmlElement(ElementName = "ILN")]
        public string ILN { get; set; }
        [XmlElement(ElementName = "TaxID")]
        public string TaxID { get; set; }
        [XmlElement(ElementName = "CodeByBuyer")]
        public string CodeByBuyer { get; set; }
        [XmlElement(ElementName = "AccountNumber")]
        public string AccountNumber { get; set; }
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "StreetAndNumber")]
        public string StreetAndNumber { get; set; }
        [XmlElement(ElementName = "CityName")]
        public string CityName { get; set; }
        [XmlElement(ElementName = "PostalCode")]
        public string PostalCode { get; set; }
        [XmlElement(ElementName = "Country")]
        public string Country { get; set; }
        [XmlElement(ElementName = "CourtAndCapitalInformation")]
        public string CourtAndCapitalInformation { get; set; }
        [XmlElement(ElementName = "ContactInformation")]
        public string ContactInformation { get; set; }
        [XmlElement(ElementName = "ContactPerson")]
        public string ContactPerson { get; set; }
        [XmlElement(ElementName = "PhoneNumber")]
        public string PhoneNumber { get; set; }
        [XmlElement(ElementName = "Fax")]
        public string Fax { get; set; }
        [XmlElement(ElementName = "ElectronicMail")]
        public string ElectronicMail { get; set; }
    }

    [XmlRoot(ElementName = "BuyerHeadquarters")]
    public class BuyerHeadquarters
    {
        [XmlElement(ElementName = "ILN")]
        public string ILN { get; set; }
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "StreetAndNumber")]
        public string StreetAndNumber { get; set; }
        [XmlElement(ElementName = "CityName")]
        public string CityName { get; set; }
        [XmlElement(ElementName = "PostalCode")]
        public string PostalCode { get; set; }
        [XmlElement(ElementName = "Country")]
        public string Country { get; set; }
        [XmlElement(ElementName = "ContactInformation")]
        public string ContactInformation { get; set; }
        [XmlElement(ElementName = "ContactPerson")]
        public string ContactPerson { get; set; }
        [XmlElement(ElementName = "PhoneNumber")]
        public string PhoneNumber { get; set; }
        [XmlElement(ElementName = "Fax")]
        public string Fax { get; set; }
        [XmlElement(ElementName = "ElectronicMail")]
        public string ElectronicMail { get; set; }
    }

    [XmlRoot(ElementName = "Invoicee")]
    public class Invoicee
    {
        [XmlElement(ElementName = "ILN")]
        public string ILN { get; set; }
        [XmlElement(ElementName = "TaxID")]
        public string TaxID { get; set; }
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "StreetAndNumber")]
        public string StreetAndNumber { get; set; }
        [XmlElement(ElementName = "CityName")]
        public string CityName { get; set; }
        [XmlElement(ElementName = "PostalCode")]
        public string PostalCode { get; set; }
        [XmlElement(ElementName = "Country")]
        public string Country { get; set; }
        [XmlElement(ElementName = "ContactInformation")]
        public string ContactInformation { get; set; }
        [XmlElement(ElementName = "ContactPerson")]
        public string ContactPerson { get; set; }
        [XmlElement(ElementName = "PhoneNumber")]
        public string PhoneNumber { get; set; }
        [XmlElement(ElementName = "Fax")]
        public string Fax { get; set; }
        [XmlElement(ElementName = "ElectronicMail")]
        public string ElectronicMail { get; set; }
    }

    [XmlRoot(ElementName = "Seller")]
    public class Seller
    {
        [XmlElement(ElementName = "ILN")]
        public string ILN { get; set; }
        [XmlElement(ElementName = "TaxID")]
        public string TaxID { get; set; }
        [XmlElement(ElementName = "AccountNumber")]
        public string AccountNumber { get; set; }
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "StreetAndNumber")]
        public string StreetAndNumber { get; set; }
        [XmlElement(ElementName = "CityName")]
        public string CityName { get; set; }
        [XmlElement(ElementName = "PostalCode")]
        public string PostalCode { get; set; }
        [XmlElement(ElementName = "Country")]
        public string Country { get; set; }
        [XmlElement(ElementName = "CodeByBuyer")]
        public string CodeByBuyer { get; set; }
        [XmlElement(ElementName = "ContactInformation")]
        public string ContactInformation { get; set; }
        [XmlElement(ElementName = "ContactPerson")]
        public string ContactPerson { get; set; }
        [XmlElement(ElementName = "PhoneNumber")]
        public string PhoneNumber { get; set; }
        [XmlElement(ElementName = "Fax")]
        public string Fax { get; set; }
        [XmlElement(ElementName = "ElectronicMail")]
        public string ElectronicMail { get; set; }
    }

    [XmlRoot(ElementName = "DeliveryPoint")]
    public class DeliveryPoint
    {
        [XmlElement(ElementName = "ILN")]
        public string ILN { get; set; }
        [XmlElement(ElementName = "CodeByBuyer")]
        public string CodeByBuyer { get; set; }
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "StreetAndNumber")]
        public string StreetAndNumber { get; set; }
        [XmlElement(ElementName = "CityName")]
        public string CityName { get; set; }
        [XmlElement(ElementName = "PostalCode")]
        public string PostalCode { get; set; }
        [XmlElement(ElementName = "Country")]
        public string Country { get; set; }
        [XmlElement(ElementName = "ContactInformation")]
        public string ContactInformation { get; set; }
        [XmlElement(ElementName = "ContactPerson")]
        public string ContactPerson { get; set; }
        [XmlElement(ElementName = "PhoneNumber")]
        public string PhoneNumber { get; set; }
        [XmlElement(ElementName = "Fax")]
        public string Fax { get; set; }
        [XmlElement(ElementName = "ElectronicMail")]
        public string ElectronicMail { get; set; }
    }

    [XmlRoot(ElementName = "ShipFrom")]
    public class ShipFrom
    {
        [XmlElement(ElementName = "ILN")]
        public string ILN { get; set; }
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "StreetAndNumber")]
        public string StreetAndNumber { get; set; }
        [XmlElement(ElementName = "CityName")]
        public string CityName { get; set; }
        [XmlElement(ElementName = "PostalCode")]
        public string PostalCode { get; set; }
        [XmlElement(ElementName = "Country")]
        public string Country { get; set; }
        [XmlElement(ElementName = "ContactInformation")]
        public string ContactInformation { get; set; }
        [XmlElement(ElementName = "ContactPerson")]
        public string ContactPerson { get; set; }
        [XmlElement(ElementName = "PhoneNumber")]
        public string PhoneNumber { get; set; }
        [XmlElement(ElementName = "Fax")]
        public string Fax { get; set; }
        [XmlElement(ElementName = "ElectronicMail")]
        public string ElectronicMail { get; set; }
    }

    [XmlRoot(ElementName = "UltimateCustomer")]
    public class UltimateCustomer
    {
        [XmlElement(ElementName = "ILN")]
        public string ILN { get; set; }
        [XmlElement(ElementName = "CodeByBuyer")]
        public string CodeByBuyer { get; set; }
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "StreetAndNumber")]
        public string StreetAndNumber { get; set; }
        [XmlElement(ElementName = "CityName")]
        public string CityName { get; set; }
        [XmlElement(ElementName = "PostalCode")]
        public string PostalCode { get; set; }
        [XmlElement(ElementName = "Country")]
        public string Country { get; set; }
        [XmlElement(ElementName = "ContactInformation")]
        public string ContactInformation { get; set; }
        [XmlElement(ElementName = "ContactPerson")]
        public string ContactPerson { get; set; }
        [XmlElement(ElementName = "PhoneNumber")]
        public string PhoneNumber { get; set; }
        [XmlElement(ElementName = "Fax")]
        public string Fax { get; set; }
        [XmlElement(ElementName = "ElectronicMail")]
        public string ElectronicMail { get; set; }
    }

    [XmlRoot(ElementName = "Carrier")]
    public class Carrier
    {
        [XmlElement(ElementName = "ILN")]
        public string ILN { get; set; }
        [XmlElement(ElementName = "ModeOfTransport")]
        public string ModeOfTransport { get; set; }
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "StreetAndNumber")]
        public string StreetAndNumber { get; set; }
        [XmlElement(ElementName = "CityName")]
        public string CityName { get; set; }
        [XmlElement(ElementName = "PostalCode")]
        public string PostalCode { get; set; }
        [XmlElement(ElementName = "Country")]
        public string Country { get; set; }
        [XmlElement(ElementName = "ContactInformation")]
        public string ContactInformation { get; set; }
        [XmlElement(ElementName = "ContactPerson")]
        public string ContactPerson { get; set; }
        [XmlElement(ElementName = "PhoneNumber")]
        public string PhoneNumber { get; set; }
        [XmlElement(ElementName = "Fax")]
        public string Fax { get; set; }
        [XmlElement(ElementName = "ElectronicMail")]
        public string ElectronicMail { get; set; }
    }

    [XmlRoot(ElementName = "OrderedBy")]
    public class OrderedBy
    {
        [XmlElement(ElementName = "ILN")]
        public string ILN { get; set; }
        [XmlElement(ElementName = "TaxID")]
        public string TaxID { get; set; }
        [XmlElement(ElementName = "AccountNumber")]
        public string AccountNumber { get; set; }
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "StreetAndNumber")]
        public string StreetAndNumber { get; set; }
        [XmlElement(ElementName = "CityName")]
        public string CityName { get; set; }
        [XmlElement(ElementName = "PostalCode")]
        public string PostalCode { get; set; }
        [XmlElement(ElementName = "Country")]
        public string Country { get; set; }
        [XmlElement(ElementName = "ContactInformation")]
        public string ContactInformation { get; set; }
        [XmlElement(ElementName = "ContactPerson")]
        public string ContactPerson { get; set; }
        [XmlElement(ElementName = "PhoneNumber")]
        public string PhoneNumber { get; set; }
        [XmlElement(ElementName = "Fax")]
        public string Fax { get; set; }
        [XmlElement(ElementName = "ElectronicMail")]
        public string ElectronicMail { get; set; }
    }

    [XmlRoot(ElementName = "Sender")]
    public class Sender
    {
        [XmlElement(ElementName = "ILN")]
        public string ILN { get; set; }
        [XmlElement(ElementName = "TaxID")]
        public string TaxID { get; set; }
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "StreetAndNumber")]
        public string StreetAndNumber { get; set; }
        [XmlElement(ElementName = "CityName")]
        public string CityName { get; set; }
        [XmlElement(ElementName = "PostalCode")]
        public string PostalCode { get; set; }
        [XmlElement(ElementName = "Country")]
        public string Country { get; set; }
        [XmlElement(ElementName = "ContactInformation")]
        public string ContactInformation { get; set; }
        [XmlElement(ElementName = "ContactPerson")]
        public string ContactPerson { get; set; }
        [XmlElement(ElementName = "PhoneNumber")]
        public string PhoneNumber { get; set; }
        [XmlElement(ElementName = "Fax")]
        public string Fax { get; set; }
        [XmlElement(ElementName = "ElectronicMail")]
        public string ElectronicMail { get; set; }
    }

    [XmlRoot(ElementName = "Receiver")]
    public class Receiver
    {
        [XmlElement(ElementName = "ILN")]
        public string ILN { get; set; }
        [XmlElement(ElementName = "TaxID")]
        public string TaxID { get; set; }
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "StreetAndNumber")]
        public string StreetAndNumber { get; set; }
        [XmlElement(ElementName = "CityName")]
        public string CityName { get; set; }
        [XmlElement(ElementName = "PostalCode")]
        public string PostalCode { get; set; }
        [XmlElement(ElementName = "Country")]
        public string Country { get; set; }
        [XmlElement(ElementName = "ContactInformation")]
        public string ContactInformation { get; set; }
        [XmlElement(ElementName = "ContactPerson")]
        public string ContactPerson { get; set; }
        [XmlElement(ElementName = "PhoneNumber")]
        public string PhoneNumber { get; set; }
        [XmlElement(ElementName = "Fax")]
        public string Fax { get; set; }
        [XmlElement(ElementName = "ElectronicMail")]
        public string ElectronicMail { get; set; }
    }

    [XmlRoot(ElementName = "Order-Parties")]
    public class OrderParties
    {
        [XmlElement(ElementName = "Buyer")]
        public Buyer Buyer { get; set; }
        [XmlElement(ElementName = "BuyerHeadquarters")]
        public BuyerHeadquarters BuyerHeadquarters { get; set; }
        [XmlElement(ElementName = "Invoicee")]
        public Invoicee Invoicee { get; set; }
        [XmlElement(ElementName = "Seller")]
        public Seller Seller { get; set; }
        [XmlElement(ElementName = "DeliveryPoint")]
        public DeliveryPoint DeliveryPoint { get; set; }
        [XmlElement(ElementName = "ShipFrom")]
        public ShipFrom ShipFrom { get; set; }
        [XmlElement(ElementName = "UltimateCustomer")]
        public UltimateCustomer UltimateCustomer { get; set; }
        [XmlElement(ElementName = "Carrier")]
        public Carrier Carrier { get; set; }
        [XmlElement(ElementName = "OrderedBy")]
        public OrderedBy OrderedBy { get; set; }
        [XmlElement(ElementName = "Sender")]
        public Sender Sender { get; set; }
        [XmlElement(ElementName = "Receiver")]
        public Receiver Receiver { get; set; }
    }

    [XmlRoot(ElementName = "Allowance")]
    public class Allowance
    {
        [XmlElement(ElementName = "Percentage")]
        public string Percentage { get; set; }
        [XmlElement(ElementName = "AllowanceAmount")]
        public string AllowanceAmount { get; set; }
        [XmlElement(ElementName = "UnitAllowanceAmount")]
        public string UnitAllowanceAmount { get; set; }
        [XmlElement(ElementName = "OriginalAmount")]
        public string OriginalAmount { get; set; }
        [XmlElement(ElementName = "AllowanceNumber")]
        public string AllowanceNumber { get; set; }
    }

    [XmlRoot(ElementName = "Charge")]
    public class Charge
    {
        [XmlElement(ElementName = "Percentage")]
        public string Percentage { get; set; }
        [XmlElement(ElementName = "ChargeAmount")]
        public string ChargeAmount { get; set; }
        [XmlElement(ElementName = "UnitChargeAmount")]
        public string UnitChargeAmount { get; set; }
        [XmlElement(ElementName = "OriginalAmount")]
        public string OriginalAmount { get; set; }
        [XmlElement(ElementName = "ChargeNumber")]
        public string ChargeNumber { get; set; }
    }

    [XmlRoot(ElementName = "Line-Item")]
    public class LineItem
    {
        [XmlElement(ElementName = "LineNumber")]
        public string LineNumber { get; set; }
        [XmlElement(ElementName = "SubLineNumber")]
        public string SubLineNumber { get; set; }
        [XmlElement(ElementName = "BuyerLineNumber")]
        public string BuyerLineNumber { get; set; }
        [XmlElement(ElementName = "EAN")]
        public string EAN { get; set; }
        [XmlElement(ElementName = "BuyerItemCode")]
        public string BuyerItemCode { get; set; }
        [XmlElement(ElementName = "SupplierItemCode")]
        public string SupplierItemCode { get; set; }
        [XmlElement(ElementName = "PackageEAN")]
        public string PackageEAN { get; set; }
        [XmlElement(ElementName = "ItemDescription")]
        public string ItemDescription { get; set; }
        [XmlElement(ElementName = "ItemType")]
        public string ItemType { get; set; }
        [XmlElement(ElementName = "OrderedQuantity")]
        public string OrderedQuantity { get; set; }
        [XmlElement(ElementName = "FreeOrderedQuantity")]
        public string FreeOrderedQuantity { get; set; }
        [XmlElement(ElementName = "OrderedUnitPacksize")]
        public string OrderedUnitPacksize { get; set; }
        [XmlElement(ElementName = "InvoicedQuantity")]
        public string InvoicedQuantity { get; set; }
        [XmlElement(ElementName = "UnitOfMeasure")]
        public string UnitOfMeasure { get; set; }
        [XmlElement(ElementName = "OrderedUnitNetPrice")]
        public string OrderedUnitNetPrice { get; set; }
        [XmlElement(ElementName = "OrderedUnitRetailPrice")]
        public string OrderedUnitRetailPrice { get; set; }
        [XmlElement(ElementName = "OrderedUnitListPrice")]
        public string OrderedUnitListPrice { get; set; }
        [XmlElement(ElementName = "OrderedUnitGrossPrice")]
        public string OrderedUnitGrossPrice { get; set; }
        [XmlElement(ElementName = "NetAmount")]
        public string NetAmount { get; set; }
        [XmlElement(ElementName = "OrderCurrency")]
        public string OrderCurrency { get; set; }
        [XmlElement(ElementName = "ExpectedDeliveryDate")]
        public string ExpectedDeliveryDate { get; set; }
        [XmlElement(ElementName = "ExpectedDeliveryTime")]
        public string ExpectedDeliveryTime { get; set; }
        [XmlElement(ElementName = "LatestDeliveryDate")]
        public string LatestDeliveryDate { get; set; }
        [XmlElement(ElementName = "LatestDeliveryTime")]
        public string LatestDeliveryTime { get; set; }
        [XmlElement(ElementName = "EarliestDeliveryDate")]
        public string EarliestDeliveryDate { get; set; }
        [XmlElement(ElementName = "EarliestDeliveryTime")]
        public string EarliestDeliveryTime { get; set; }
        [XmlElement(ElementName = "ExpirationDate")]
        public string ExpirationDate { get; set; }
        [XmlElement(ElementName = "PackageNumber")]
        public string PackageNumber { get; set; }
        [XmlElement(ElementName = "PackageType")]
        public string PackageType { get; set; }
        [XmlElement(ElementName = "Remarks")]
        public string Remarks { get; set; }
        [XmlElement(ElementName = "FlowType")]
        public string FlowType { get; set; }
        [XmlElement(ElementName = "Allowance")]
        public Allowance Allowance { get; set; }
        [XmlElement(ElementName = "Charge")]
        public Charge Charge { get; set; }
    }

    [XmlRoot(ElementName = "Line-Parties")]
    public class LineParties
    {
        [XmlElement(ElementName = "DeliveryPoint")]
        public DeliveryPoint DeliveryPoint { get; set; }
    }

    [XmlRoot(ElementName = "Line")]
    public class Line
    {
        [XmlElement(ElementName = "Line-Item")]
        public LineItem LineItem { get; set; }
        [XmlElement(ElementName = "Line-Parties")]
        public LineParties LineParties { get; set; }
    }

    [XmlRoot(ElementName = "Order-Lines")]
    public class OrderLines
    {
        [XmlElement(ElementName = "Line")]
        public List<Line> Line { get; set; }
    }

    [XmlRoot(ElementName = "Order-Summary")]
    public class OrderSummary
    {
        [XmlElement(ElementName = "TotalLines")]
        public string TotalLines { get; set; }
        [XmlElement(ElementName = "TotalOrderedAmount")]
        public string TotalOrderedAmount { get; set; }
        [XmlElement(ElementName = "TotalNetAmount")]
        public string TotalNetAmount { get; set; }
        [XmlElement(ElementName = "TotalTaxAmount")]
        public string TotalTaxAmount { get; set; }
        [XmlElement(ElementName = "TotalGrossAmount")]
        public string TotalGrossAmount { get; set; }
    }

    [XmlRoot(ElementName = "Document-Order")]
    public class DocumentOrder
    {
        [XmlElement(ElementName = "Order-Header")]
        public OrderHeader OrderHeader { get; set; }
        [XmlElement(ElementName = "Order-Parties")]
        public OrderParties OrderParties { get; set; }
        [XmlElement(ElementName = "Order-Lines")]
        public OrderLines OrderLines { get; set; }
        [XmlElement(ElementName = "Order-Summary")]
        public OrderSummary OrderSummary { get; set; }
    }

}
