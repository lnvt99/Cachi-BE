using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity.Models
{
    public partial class Material
    {
        public Material()
        {
            MaterialsRecipes = new HashSet<MaterialsRecipe>();
        }
        [Key]
        public int MaterialId { get; set; }
        public string MaterialName { get; set; } = null!;
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        public string Unit { get; set; } = null!;
        public byte IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateLastModified { get; set; }

        public virtual ICollection<MaterialsRecipe> MaterialsRecipes { get; set; }
    }
}
