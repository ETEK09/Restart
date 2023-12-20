namespace Restart.Models
{
    public class Product
    {
        public int MovesID { get; set; }

        public string InventoryTag { get; set; }
        public string Custodian { get; set; }

        public DateTime Assigned { get; set; }

        public IEnumerable<DistributorsIT> Distributor { get; set; }
        //public string distributor { get; set; }

        public string JotForm { get; set; }

        public string UploadForm { get; set; }

        public int Products { get; set; }
    }
}
