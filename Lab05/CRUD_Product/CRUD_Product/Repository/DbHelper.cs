using CRUD_Product.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_Product.Repository
{
    public class DbHelper
    {
        public Product CreateProduct(Product productModel)
        {
            using (var dbEntities = new ProductContext())
            {
                var productObj = new Product()
                {
                    Name = productModel.Name,
                    Price = productModel.Price
                };
                dbEntities.Products.Add(productObj);
                dbEntities.SaveChanges();
                productModel.Id = productObj.Id;
            }
            return productModel;
        }
        public Product ModifyProduct(Product productModel)
        {
            using (var dbEntities = new ProductContext())
            {
                var productObj = new Product()
                {
                    Name = productModel.Name,
                    Id = productModel.Id,
                    Price = productModel.Price
                };
                dbEntities.Entry(productObj).State = System.Data.Entity.EntityState.Modified;
                dbEntities.SaveChanges();
                productModel.Id = productObj.Id;
            }
            return productModel;
        }
        //public Product DeleteProduct(Product productModel,int id)
        //{
        //    using (var dbEntities = new ProductContext())
        //    {
        //        var productObj = dbEntities.Products.SingleOrDefault(e => e.Id == id);
        //        dbEntities.Products.Remove(productObj);
        //        dbEntities.SaveChanges();
        //        productModel.Id = productObj.Id;
        //    }
        //    return productModel;
        //}

    }
}