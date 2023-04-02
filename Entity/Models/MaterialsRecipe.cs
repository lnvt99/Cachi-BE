using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity.Models
{
    public partial class MaterialsRecipe
    {
        [Key]
        public int MaterialsRecipeId { get; set; }
        public int MaterialId { get; set; }
        public int RecipeId { get; set; }
        public decimal Amount { get; set; }
        public byte IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateLastModified { get; set; }

        public virtual Material Material { get; set; } = null!;
        public virtual Recipe Recipe { get; set; } = null!;
    }
}
