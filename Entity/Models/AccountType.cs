using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models
{
    public class AccountType
    {
        public AccountType()
        {
            Accounts = new HashSet<Account>();
        }
        [Key]
        public int TypeId { get; set; }
        public string TypeName { get; set; } = null!;
        public byte IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateLastModified { get; set; }
        [ForeignKey("AccountId")]
        public virtual ICollection<Account> Accounts { get; set; }
    }
}
