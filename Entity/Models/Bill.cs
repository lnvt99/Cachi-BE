using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity.Models
{
    public class Bill
    {
        public Bill()
        {
            BillsDetails = new HashSet<BillsDetail>();
        }
        [Key]
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
