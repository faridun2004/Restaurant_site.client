using Restaurant_site.client.DTO;
using System.Net.Http.Json;
using Restaurant_site.client.Services;

namespace Restaurant_site.client.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<ProductDTO>> GetAllProducts()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<ProductDTO>>("api/products");
        }

        public async Task<ProductDTO> GetProductById(int id)
        {
            return await _httpClient.GetFromJsonAsync<ProductDTO>($"api/products/{id}");
        }

        public async Task AddProduct(ProductDTO product, MultipartFormDataContent content)
        {
            var response = await _httpClient.PostAsync("api/products", content);
            response.EnsureSuccessStatusCode();
        }

        public async Task UpdateProduct(ProductDTO product, MultipartFormDataContent content)
        {
            var response = await _httpClient.PutAsync($"api/products/{product.Id}", content);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteProduct(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/products/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
