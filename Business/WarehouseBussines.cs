using Entities;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Business
{
    public class WarehouseBusiness 
    {

        public static List<WarehouseEntity> WarehouseList()
        {
            using (var db = new InventaryContext())
            {
                return db.Warehouse.ToList();
            }
        }

        public static WarehouseEntity WarehouseById(string id)
        {
            using (var db = new InventaryContext())
            {
                return db.Warehouse.ToList().LastOrDefault(p => p.WarehouseId == id);
            }
        }

        public static void CreateWarehouse(WarehouseEntity objWarehouse)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouse.Add(objWarehouse);
                db.SaveChanges();
            }
        }

        public static void UpdateWarehouse(WarehouseEntity objWarehouse)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouse.Update(objWarehouse);
                db.SaveChanges();
            }
        }

        public static void DeleteWarehouse(WarehouseEntity objWarehouse)
        {
            //Eliminar
        }
    }
}
