using Restaurant_site.client.DTO;

namespace Restaurant_site.client.Services
{
    public interface IProductCategoryService
    {
        Task<List<ProductCategory>> GetProductCategoriesAsync();
        Task<ProductCategory> GetProductCategoryByIdAsync(int id);
        Task AddProductCategoryAsync(ProductCategoryCreateDto categoryCreateDto);
        Task UpdateProductCategoryAsync(ProductCategory category);
        Task DeleteProductCategoryAsync(int id);
    }
}
