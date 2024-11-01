using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;
using WebApplication1.Services.Interfaces;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {

        public ProductController(IProductService productService)
        {
          _productService = productService;
        }

        IProductService _productService;
        [HttpGet]
        public async Task<List<Product>> GetProducts()
        {
            return await _productService.GetProducts();
        }

        [HttpPost]
        public async Task<bool> RegisterProduct(Product product)
        {
            return await _productService.RegisterProduct(product);
        }

        [HttpDelete]
        public async Task<bool> DeleteProduct(int id)
        {
            return await _productService.DeleteProduct(id);
        }


        [HttpPut]
        public async Task<bool> UpdateProduct(int id)
        {
            return await _productService.UpdateProduct(id);
        }
    }
}
}
