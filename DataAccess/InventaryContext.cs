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


    }
}
