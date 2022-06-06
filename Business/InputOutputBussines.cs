using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using Entities;

namespace Business
{
    public class InputOutputBussines 
    {
        public static List<InputOutputEntity> InOutList()
        {
            using (var db = new InventaryContext())
            {
                return db.InOut.ToList();
            }
        }

        public static InputOutputEntity InOutById(string id)
        {
            using (var db = new InventaryContext())
            {
                return db.InOut.ToList().LastOrDefault(p => p.InputOutputId== id);
            }
        }

        public static void CreateInOut(InputOutputEntity objInOut)
        {
            using (var db = new InventaryContext())
            {
                db.InOut.Add(objInOut);
                db.SaveChanges();
            }
        }

        public static void UpdateInOut(InputOutputEntity objInOut)
        {
            using (var db = new InventaryContext())
            {
                db.InOut.Update(objInOut);
                db.SaveChanges();
            }
        }

        public static void DeleteInOut(InputOutputEntity objInOut)
        {
            // Eliminar
        }
    }
}
