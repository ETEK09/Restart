namespace Restart.Models
{
    public class Product
    {
        public int MovesID { get; set; }

        public string InventoryTag { get; set; }
        public string Custodian { get; set; }

        public DateTime Assigned { get; set; }

        public int DistributorId { get; set; }
        public string Distributor { get; set; }

        public string JotForm { get; set; }

        public string UploadForm { get; set; }

        public int Products { get; set; }
    }
}
