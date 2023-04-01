using System;
using System.Collections.Generic;

namespace Entity.Models
{
    public partial class AccountType
    {
        public AccountType()
        {
            Accounts = new HashSet<Account>();
        }

        public byte TypeId { get; set; }
        public string TypeName { get; set; } = null!;
        public byte IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateLastModified { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
