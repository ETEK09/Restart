using System.ComponentModel.DataAnnotations;

namespace Restart.Models
{
    public class Custodian
    {
        public int Assignees { get; set; }

        public int IneventorTag { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public DateOnly DateAssigned { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }
    }
}
