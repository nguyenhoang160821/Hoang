using CRUD_Product.Models;
using CRUD_Product.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_Product
{
    public class ProductRepository
    {
        public Product PostProductDetails(Product ProductModel)
        {
            DbHelper dbInstance = new DbHelper();
            return dbInstance.CreateProduct(ProductModel);
        }
        public Product PostProductModify(Product ProductModel)
        {
            DbHelper dbInstance = new DbHelper();
            return dbInstance.ModifyProduct(ProductModel);
        }
        //public Product PostDeleteProduct(int id)
        //{
        //    DbHelper dbInstance = new DbHelper();
        //    return dbInstance.ModifyProduct(id);
        //}
    }
}