using Restaurant_site.client.DTO;
using System.Net.Http.Json;

namespace Restaurant_site.client.Services
{
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly HttpClient _httpClient;

        public ProductCategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ProductCategory>> GetProductCategoriesAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<ProductCategory>>("api/productcategories");
        }

        public async Task<ProductCategory> GetProductCategoryByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<ProductCategory>($"api/productcategories/{id}");
        }

        public async Task AddProductCategoryAsync(ProductCategoryCreateDto categoryCreateDto)
        {
            var response = await _httpClient.PostAsJsonAsync("api/productcategories", categoryCreateDto);
            response.EnsureSuccessStatusCode();
        }

        public async Task UpdateProductCategoryAsync(ProductCategory category)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/productcategories/{category.Id}", category);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteProductCategoryAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/productcategories/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
