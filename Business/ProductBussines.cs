using Entities;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Business
{
    public class ProductBusiness : ICRUD<ProductEntity>
    {

        public List<ProductEntity> ItemList()
        {
            using (var db = new InventaryContext())
            {
                return db.Product.ToList();
            }
        }

        public void CreateItem(ProductEntity objProduct)
        {
            using (var db = new InventaryContext())
            {
                db.Product.Add(objProduct);
                db.SaveChanges();
            }
        }

        public void UpdateItem(ProductEntity objProduct)
        {
            using (var db = new InventaryContext())
            {
                db.Product.Update(objProduct);
                db.SaveChanges();
            }
        }

        public void DeleteItem(ProductEntity objProduct)
        {
            //Eliminar
        }
    }
}
