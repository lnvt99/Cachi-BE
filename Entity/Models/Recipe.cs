using System;
using System.Collections.Generic;

namespace Entity.Models
{
    public partial class Recipe
    {
        public Recipe()
        {
            MaterialsRecipes = new HashSet<MaterialsRecipe>();
            Products = new HashSet<Product>();
            RecipesSizes = new HashSet<RecipesSize>();
        }

        public int RecipeId { get; set; }
        public string RecipeName { get; set; } = null!;
        public byte IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateLastModified { get; set; }

        public virtual ICollection<MaterialsRecipe> MaterialsRecipes { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<RecipesSize> RecipesSizes { get; set; }
    }
}
