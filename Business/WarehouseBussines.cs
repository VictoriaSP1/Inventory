using Entities;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Business
{
    public class WarehouseBusiness : ICRUD<WarehouseEntity>
    {

        public List<WarehouseEntity> ItemList()
        {
            using (var db = new InventaryContext())
            {
                return db.Warehouse.ToList();
            }
        }

        public void CreateItem(WarehouseEntity objWarehouse)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouse.Add(objWarehouse);
                db.SaveChanges();
            }
        }

        public void UpdateItem(WarehouseEntity objWarehouse)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouse.Update(objWarehouse);
                db.SaveChanges();
            }
        }

        public void DeleteItem(WarehouseEntity objWarehouse)
        {
            //Eliminar
        }
    }
}
