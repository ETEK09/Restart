namespace Restart.Models
{
    public class Distributor
    {
        public int Actions { get; set; }
        public int InventoryTag { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public string Custodian { get; set; }

        public DateOnly DateEntered { get; set; }

        public string JotForm { get; set; }
    }
}
