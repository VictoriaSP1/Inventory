using Entities;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Business
{
    public class CategoryBusiness 
    {
        
        public static List<CategoryEntity> CategoryList()
        {
            using (var db = new InventaryContext())
            {
                return db.Category.ToList();
            }         
        }

        public static void CreateCategory(CategoryEntity objCategory)
        {
            using (var db = new InventaryContext())
            {
                db.Category.Add(objCategory);
                db.SaveChanges();
            }
        }

        public static void UpdateCategory(CategoryEntity objCategory)
        {
            using (var db = new InventaryContext())
            {
                db.Category.Update(objCategory);
                db.SaveChanges();
            }
        }

        public static void DeleteCategory(CategoryEntity objCategory)
        {
            //Eliminar
        }
    }
}


