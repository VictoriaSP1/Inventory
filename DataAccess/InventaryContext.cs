using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class InventaryContext : DbContext
    {
        public DbSet <ProductEntity> Product { get; set; }
        public DbSet <CategoryEntity> Category { get; set; }
        public DbSet <InputOutputEntity> InOut { get; set; }
        public DbSet <WarehouseEntity> Warehouse { get; set; }
        public DbSet <StorageEntity> Storage { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=localhost; Database=InventoryDB; Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { CategoryId="ASH", CategoryName="Aseo del hogar"},
                new CategoryEntity { CategoryId = "ASP", CategoryName = "Aseo Personal" },
                new CategoryEntity { CategoryId = "HGR", CategoryName = "Hogar" },
                new CategoryEntity { CategoryId = "PRF", CategoryName = "Perfumería" },
                new CategoryEntity { CategoryId = "SLD", CategoryName = "Salud" },
                new CategoryEntity { CategoryId = "VDJ", CategoryName = "Video Juegos" }
                );

            modelBuilder.Entity<WarehouseEntity>().HasData(
                new WarehouseEntity { WarehouseId=Guid.NewGuid().ToString(),
                    WarehouseName = "Bodega Central",
                    WarehouseAddress = "Calle 8 con 23"
                },
                new WarehouseEntity { WarehouseId = Guid.NewGuid().ToString(), 
                    WarehouseName = "Bodega Norte", 
                    WarehouseAddress = "Calle norte con occidente" }
                );

            modelBuilder.Entity<ProductEntity>().HasData(
                new ProductEntity { ProductId = "ASJ-98745", 
                    ProductName = "Crema para manos marca Tersa", 
                    ProductDescription = "", 
                    CategoryId = "PRF" 
                },
                new ProductEntity { ProductId = "RPT-54658", 
                    ProductName = "Pastillas para la garganta LESUS", 
                    ProductDescription = "", 
                    CategoryId = "SLD" }
                );
        }
    }
}
