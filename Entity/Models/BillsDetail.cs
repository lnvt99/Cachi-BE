using System;
using System.Collections.Generic;

namespace Entity.Models
{
    public partial class BillsDetail
    {
        public int BillDetailId { get; set; }
        public int ProductId { get; set; }
        public int BillId { get; set; }
        public int Amount { get; set; }
        public byte IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateLastModified { get; set; }

        public virtual Bill Bill { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
