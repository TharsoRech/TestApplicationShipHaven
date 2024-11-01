using WebApplication1.Context.Interface;
using WebApplication1.Models;
using WebApplication1.Services.Interfaces;

namespace WebApplication1.Services
{
    public class ProductService: IProductService
    {
        IDapperContext _dapperContext;

        public ProductService(IDapperContext dapperContext) 
        {
            _dapperContext = dapperContext;   
        }
        public async Task<bool> RegisterProduct(Product product) {

            return false;
        }

        public async Task<bool> DeleteProduct(int  id)
        {
            return false;
        }

        public async Task<bool> UpdateProduct(int id)
        {
            return false;
        }

        public async Task<List<Product>> GetProducts()
        {
            return null;
        }
    }
}
