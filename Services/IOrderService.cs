using Restaurant_site.client.Components;
using Restaurant_site.client.DTO;

namespace Restaurant_site.client.Services
{
    public interface IOrderService
    {
        Task<Guid> CreateOrder();
        Task<OrderDTO> GetOrder(Guid orderId);
        Task<IEnumerable<OrderDTO>> GetOrders();
    }
}
