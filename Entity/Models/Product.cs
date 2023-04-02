using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity.Models
{
    public partial class Product
    {
        public Product()
        {
            BillsDetails = new HashSet<BillsDetail>();
        }
        [Key]
        public int ProductId { get; set; }
        public int RecipeId { get; set; }
        public string ProductName { get; set; } = null!;
        public string Image { get; set; } = null!;
        public decimal Price { get; set; }
        public byte IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateLastModified { get; set; }

        public virtual Recipe Recipe { get; set; } = null!;
        public virtual ICollection<BillsDetail> BillsDetails { get; set; }
    }
}
