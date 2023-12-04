namespace Restart.Models
{
    public class ITProducts
    {
        public int ProductID { get; set; }
        public string InventoryTag { get; set; }
        public string ProductName { get; set; }

        public string Description { get; set; }

        public DateTime DateAssigned { get; set; }

        public string ITDistributor { get; set; }

        public string Custodian { get; set; }

        public string UploadForm { get; set; }
    }
}
