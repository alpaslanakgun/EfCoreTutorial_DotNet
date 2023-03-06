using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfCoreTutorial.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EfCoreTutorial.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        protected ApplicationDbContext()
        {

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //make the configurations
                optionsBuilder.UseSqlServer("Data Source=ALPASLAN_AKGUN\\MSSQLSERVERA;Initial Catalog=EFCoredb;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)//Mapping Operations
        {
            modelBuilder.HasDefaultSchema("dbo");

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("products");
              
                entity.Property(i => i.ID).HasColumnName("id").HasColumnType("int").UseIdentityColumn().IsRequired();
                entity.Property(i => i.ProductName).HasColumnName("product_name").HasColumnType("nvarchar").HasMaxLength(100);
                entity.Property(i => i.UnitPrice).HasColumnName("unit_price").HasColumnType("decimal");
                entity.Property(i => i.UnitsInStock).HasColumnName("units_in_stock").HasColumnType("smallint");
                entity.Property(i => i.IsActive).HasColumnName("is_active");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("categories");
                entity.Property(i => i.ID).HasColumnName("id").HasColumnType("int").UseIdentityColumn().IsRequired();
                entity.Property(i => i.CategoryName).HasColumnName("category_name").HasColumnType("nvarchar")
                    .HasMaxLength(100);
                entity.Property(i => i.Description).HasColumnName("description").HasColumnType("nvarchar")
                    .HasMaxLength(500);
                entity.Property(i => i.IsActive).HasColumnName("is_active");
            });
            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.ToTable("suppliers");
                entity.Property(i => i.ID).HasColumnName("id").HasColumnType("int").UseIdentityColumn().IsRequired();
                entity.Property(i => i.CompanyName).HasColumnName("company_name").HasColumnType("nvarchar").HasMaxLength(100);
                entity.Property(i => i.IsActive).HasColumnName("is_active");


            });
            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable("orderdetails");
                entity.Property(i => i.ID).HasColumnName("id").HasColumnType("int").IsRequired();
                entity.Property(i => i.UnitPrice).HasColumnName("unit_price").HasColumnType("decimal");
                entity.Property(i => i.Quantity).HasColumnName("quantity").HasColumnType("decimal");
                entity.Property(i => i.Discount).HasColumnName("discount").HasColumnType("decimal");
                entity.Property(i => i.OrderDate).HasColumnName("order_date");
            });


            base.OnModelCreating(modelBuilder);
        }
    }
}
