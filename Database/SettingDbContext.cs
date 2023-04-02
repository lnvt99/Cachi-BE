using Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class SettingDbContext: DbContext
    {
        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<AccountType> AccountTypes { get; set; } = null!;
        public virtual DbSet<Bill> Bills { get; set; } = null!;
        public virtual DbSet<BillsDetail> BillsDetails { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Material> Materials { get; set; } = null!;
        public virtual DbSet<MaterialsRecipe> MaterialsRecipes { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Recipe> Recipes { get; set; } = null!;
        public virtual DbSet<RecipesSize> RecipesSizes { get; set; } = null!;
        public virtual DbSet<Size> Sizes { get; set; } = null!;

        public SettingDbContext() : base() { }

        public SettingDbContext(DbContextOptions<SettingDbContext> options): base(options) { 
        
        }
    }
}
