using Entities;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Business
{
    public class StorageBusiness
    {

        public static List<StorageEntity> StorageList()
        {
            using (var db = new InventaryContext())
            {
                return db.Storage.ToList();
            }
        }

        public static StorageEntity StorageById(string id)
        {
            using (var db = new InventaryContext())
            {
                return db.Storage.ToList().LastOrDefault(p => p.StorageId == id);
            }
        }

        public static StorageEntity CreateStorage(StorageEntity objStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storage.Add(objStorage);
                db.SaveChanges();

                return StorageById(objStorage.StorageId);
            }
        }

        public static bool IsProductInWarehouse (string idStorage)
        {
            using (var db = new InventaryContext())
            {
                var product = db.Storage.ToList()
                                .Where(s=>s.StorageId == idStorage);

                return product.Any();
            }
        }

        public static List<StorageEntity> StorageProductsByWarehouse(string idWarehouse)
        {
            using (var db = new InventaryContext())
            {
                return db.Storage
                    .Include(s=>s.Product)
                    .Include(s => s.Warehouse)
                    .Where(s=>s.WarehouseId==idWarehouse)
                    .ToList();
            }
        }

        public static void UpdateStorage(StorageEntity objStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storage.Update(objStorage);
                db.SaveChanges();
            }
        }

        public static void DeleteStorage(StorageEntity objStorage)
        {
            //Eliminar
        }
    }
}
