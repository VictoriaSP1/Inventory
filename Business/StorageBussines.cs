using Entities;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Business
{
    public class StorageBusiness : ICRUD<StorageEntity>
    {

        public List<StorageEntity> ItemList()
        {
            using (var db = new InventaryContext())
            {
                return db.Storage.ToList();
            }
        }

        public void CreateItem(StorageEntity objStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storage.Add(objStorage);
                db.SaveChanges();
            }
        }

        public void UpdateItem(StorageEntity objStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storage.Update(objStorage);
                db.SaveChanges();
            }
        }

        public void DeleteItem(StorageEntity objStorage)
        {
            //Eliminar
        }
    }
}
