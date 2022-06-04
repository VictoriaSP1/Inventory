using Entities;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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

        public static void CreateStorage(StorageEntity objStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storage.Add(objStorage);
                db.SaveChanges();
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
