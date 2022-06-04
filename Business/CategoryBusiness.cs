using Entities;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Business
{
    public class CategoryBusiness : ICRUD <CategoryEntity>
    {
        
        public List<CategoryEntity> ItemList()
        {
            using (var db = new InventaryContext())
            {
                return db.Category.ToList();
            }         
        }

        public void CreateItem(CategoryEntity objCategory)
        {
            using (var db = new InventaryContext())
            {
                db.Category.Add(objCategory);
                db.SaveChanges();
            }
        }

        public void UpdateItem(CategoryEntity objCategory)
        {
            using (var db = new InventaryContext())
            {
                db.Category.Update(objCategory);
                db.SaveChanges();
            }
        }

        public void DeleteItem(CategoryEntity objCategory)
        {
            //Eliminar
        }
    }
}


