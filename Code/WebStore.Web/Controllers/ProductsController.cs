using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebStore.Web.Controllers
{
    public class ProductsController : ApiController
    {
        private Interfaces.IProductService _productService;
        public ProductsController(Interfaces.IProductService productService)
        {
            this._productService = productService;
        }

        [HttpGet]
        public List<DTO.Product> GetProducts()
        {
            return this._productService.GetProducts();
        }
    }
}
