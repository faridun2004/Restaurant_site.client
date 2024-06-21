using Restaurant_site.client.DTO;

namespace Restaurant_site.client.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetAllProducts();
        Task<ProductDTO> GetProductById(int id);
        Task AddProduct(ProductDTO product, MultipartFormDataContent content);
        Task UpdateProduct(ProductDTO product, MultipartFormDataContent content);
        Task DeleteProduct(int id);
    }
}
