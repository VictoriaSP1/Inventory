using Entities;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Business
{
    public class ProductBusiness 
    {

        public static List<ProductEntity> ProductList()
        {
            using (var db = new InventaryContext())
            {
                return db.Product.ToList();
            }
        }

        public static void CreateProduct(ProductEntity objProduct)
        {
            using (var db = new InventaryContext())
            {
                db.Product.Add(objProduct);
                db.SaveChanges();
            }
        }

        public static void UpdateProduct(ProductEntity objProduct)
        {
            using (var db = new InventaryContext())
            {
                db.Product.Update(objProduct);
                db.SaveChanges();
            }
        }

        public static void DeleteProduct(ProductEntity objProduct)
        {
            //Eliminar
        }
    }
}
