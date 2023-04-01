using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Entity.Models
{
    public partial class Cachi_DBContext : DbContext
    {
        public Cachi_DBContext()
        {
        }

        public Cachi_DBContext(DbContextOptions<Cachi_DBContext> options)
            : base(options)
        {
        }

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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=mssql-117959-0.cloudclusters.net,19977;User ID=cachi;Password=Cachi12345;Database=Cachi_DB;Trusted_Connection=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasIndex(e => e.Type, "IX_Accounts_Type");

                entity.Property(e => e.Avatar)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateLastModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Locate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.Type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Accounts__Type__619B8048");
            });

            modelBuilder.Entity<AccountType>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("PK__AccountT__516F03B52AE3D5A0");

                entity.HasIndex(e => e.TypeName, "IX_AccountTypes_TypeName");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateLastModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Bill>(entity =>
            {
                entity.HasIndex(e => e.EmployeeId, "IX_Bills_EmployeeId");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateLastModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Bills)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Bills__EmployeeI__6EF57B66");
            });

            modelBuilder.Entity<BillsDetail>(entity =>
            {
                entity.HasKey(e => e.BillDetailId)
                    .HasName("PK__Bills_De__793CAF95BCE82854");

                entity.ToTable("Bills_Details");

                entity.HasIndex(e => e.BillId, "IX_Bills_Details_BillId");

                entity.HasIndex(e => e.ProductId, "IX_Bills_Details_ProductId");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateLastModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Bill)
                    .WithMany(p => p.BillsDetails)
                    .HasForeignKey(d => d.BillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Bills_Det__BillI__75A278F5");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.BillsDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Bills_Det__Produ__74AE54BC");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasIndex(e => e.AccountId, "IX_Employees_AccountId");

                entity.Property(e => e.Address)
                    .HasMaxLength(320)
                    .UseCollation("Vietnamese_CI_AS");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateLastModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasMaxLength(320)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .UseCollation("Vietnamese_CI_AS");

                entity.Property(e => e.NumberPhone)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Employees__Accou__68487DD7");
            });

            modelBuilder.Entity<Material>(entity =>
            {
                entity.HasIndex(e => e.MaterialName, "UQ__Material__9C87053CB4B7B111")
                    .IsUnique();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateLastModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MaterialName)
                    .HasMaxLength(50)
                    .UseCollation("Vietnamese_CI_AS");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .UseCollation("Vietnamese_CI_AS");
            });

            modelBuilder.Entity<MaterialsRecipe>(entity =>
            {
                entity.ToTable("Materials_Recipes");

                entity.HasIndex(e => e.MaterialId, "IX_Materials_Recipes_MaterialId");

                entity.HasIndex(e => e.RecipeId, "IX_Materials_Recipes_RecipeId");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateLastModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.MaterialsRecipes)
                    .HasForeignKey(d => d.MaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Materials__Mater__5070F446");

                entity.HasOne(d => d.Recipe)
                    .WithMany(p => p.MaterialsRecipes)
                    .HasForeignKey(d => d.RecipeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Materials__Recip__5165187F");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasIndex(e => e.RecipeId, "IX_Products_RecipeId");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateLastModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Image)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .UseCollation("Vietnamese_CI_AS");

                entity.HasOne(d => d.Recipe)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.RecipeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Products__Recipe__571DF1D5");
            });

            modelBuilder.Entity<Recipe>(entity =>
            {
                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateLastModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecipeName)
                    .HasMaxLength(50)
                    .UseCollation("Vietnamese_CI_AS");
            });

            modelBuilder.Entity<RecipesSize>(entity =>
            {
                entity.HasKey(e => e.RecipeSizeId)
                    .HasName("PK__Recipes___676BC42C729179AC");

                entity.ToTable("Recipes_Sizes");

                entity.HasIndex(e => e.RecipeId, "IX_Recipes_Sizes_RecipeId");

                entity.HasIndex(e => e.SizeId, "IX_Recipes_Sizes_SizeId");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateLastModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Recipe)
                    .WithMany(p => p.RecipesSizes)
                    .HasForeignKey(d => d.RecipeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Recipes_S__Recip__440B1D61");

                entity.HasOne(d => d.Size)
                    .WithMany(p => p.RecipesSizes)
                    .HasForeignKey(d => d.SizeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Recipes_S__SizeI__44FF419A");
            });

            modelBuilder.Entity<Size>(entity =>
            {
                entity.HasIndex(e => e.SizeName, "UQ__Sizes__619EFC3EA39CDA31")
                    .IsUnique();

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateLastModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SizeName)
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
