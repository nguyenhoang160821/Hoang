using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pracetice2.Models;
using Pracetice2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Pracetice2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        public ProductsController(JsonFileProductService productService)
        {
            ProductService = productService;
        }

        public JsonFileProductService ProductService { get; }

        [HttpGet]
        public IEnumerable<Products> Get()
        {
            return ProductService.GetProducts();
        }
    }
}
