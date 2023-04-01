using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models.Bills
{
    [Table("Bills")]
    public class BillsModel
    {
        [Key]
        public int BillId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime OrderDate { get; set; }
        public byte IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateLastModified { get; set; }

    }
}
