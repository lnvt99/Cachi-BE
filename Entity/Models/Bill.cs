using System;
using System.Collections.Generic;

namespace Entity.Models
{
    public partial class Bill
    {
        public Bill()
        {
            BillsDetails = new HashSet<BillsDetail>();
        }

        public int BillId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime OrderDate { get; set; }
        public byte IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateLastModified { get; set; }

        public virtual Employee Employee { get; set; } = null!;
        public virtual ICollection<BillsDetail> BillsDetails { get; set; }
    }
}
