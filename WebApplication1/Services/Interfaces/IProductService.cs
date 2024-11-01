using WebApplication1.Models;

namespace WebApplication1.Services.Interfaces
{
    public interface IProductService
    {
        Task<bool> RegisterProduct(Product product);

        Task<bool> DeleteProduct(int id);

        Task<bool> UpdateProduct(int id);

        Task<List<Product>> GetProducts();
    }
}
