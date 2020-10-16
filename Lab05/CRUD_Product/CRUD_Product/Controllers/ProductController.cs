using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CRUD_Product.Models;

using CRUD_Product.Repository;

namespace CRUD_Product.Controllers
{
    public class ProductController : ApiController
    {
        [HttpPost]
        [Authorize]
        [Route ("api/Product/Create")]
        public string PostProductDetail(Product productModel)
        {
            DbHelper dbHelper = new DbHelper();
            productModel = dbHelper.CreateProduct(productModel);
            return "Success";
        }

        [HttpPut]
        [Authorize]
        [Route("api/Product/Modify")]
        public string PostProductModify(Product productModel)
        {
            DbHelper dbHelper = new DbHelper();
            productModel = dbHelper.ModifyProduct(productModel);
            return "Success";
        }

        //[HttpDelete]
        //[Authorize]
        //[Route("api/Product/Delete/{id}")]
        //public string PostDeleteProduct(int id,Product productModel)
        //{
        //    DbHelper dbHelper = new DbHelper();
        //    id = dbHelper.DeleteProduct(id);
        //    return "Success";
        //}
    }
}
