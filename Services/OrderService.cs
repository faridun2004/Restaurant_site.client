using Restaurant_site.client.Components;
using Restaurant_site.client.DTO;
using System.Net.Http.Json;

namespace Restaurant_site.client.Services
{
    public class OrderService : IOrderService
    {
        private readonly HttpClient _httpClient;

        public OrderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Guid> CreateOrder()
        {
            var response = await _httpClient.PostAsync("api/order", null);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Guid>();
        }

        public async Task<OrderDTO> GetOrder(Guid orderId)
        {
            return await _httpClient.GetFromJsonAsync<OrderDTO>($"api/order/{orderId}");
        }

        public async Task<IEnumerable<OrderDTO>> GetOrders()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<OrderDTO>>("api/order");
        }
    }
}
