using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entity.Models
{
    public partial class RecipesSize
    {
        [Key]
        public int RecipeSizeId { get; set; }
        public int RecipeId { get; set; }
        public int SizeId { get; set; }
        public byte IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateLastModified { get; set; }

        public virtual Recipe Recipe { get; set; } = null!;
        public virtual Size Size { get; set; } = null!;
    }
}
