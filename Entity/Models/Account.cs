using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity.Models
{
    public class Account
    {
        //public Account()
        //{
        //    Employees = new HashSet<Employee>();
        //}
        [Key]
        public int AccountId { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public byte Type { get; set; }
        public string Locate { get; set; } = null!;
        public string? Avatar { get; set; }
        public byte IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateLastModified { get; set; }

        //public virtual AccountType TypeNavigation { get; set; } = null!;
        //public virtual ICollection<Employee> Employees { get; set; }
    }
}
