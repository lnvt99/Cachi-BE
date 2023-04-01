using System;
using System.Collections.Generic;

namespace Entity.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Bills = new HashSet<Bill>();
        }

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; } = null!;
        public string? NumberPhone { get; set; }
        public string Address { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int AccountId { get; set; }
        public byte IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateLastModified { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual ICollection<Bill> Bills { get; set; }
    }
}
