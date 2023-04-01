using System;
using System.Collections.Generic;

namespace Entity.Models
{
    public partial class Size
    {
        public Size()
        {
            RecipesSizes = new HashSet<RecipesSize>();
        }

        public int SizeId { get; set; }
        public string SizeName { get; set; } = null!;
        public byte IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateLastModified { get; set; }

        public virtual ICollection<RecipesSize> RecipesSizes { get; set; }
    }
}
