using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using Entities;

namespace Business
{
    public class InputOutputBussines : ICRUD<InputOutputEntity>
    {
        public List<InputOutputEntity> ItemList()
        {
            using (var db = new InventaryContext())
            {
                return db.InOut.ToList();
            }
        }

        public void CreateItem(InputOutputEntity objInOut)
        {
            using (var db = new InventaryContext())
            {
                db.InOut.Add(objInOut);
                db.SaveChanges();
            }
        }

        public void UpdateItem(InputOutputEntity objInOut)
        {
            using (var db = new InventaryContext())
            {
                db.InOut.Update(objInOut);
                db.SaveChanges();
            }
        }

        public void DeleteItem(InputOutputEntity objInOut)
        {
            // Eliminar
        }
    }
}
