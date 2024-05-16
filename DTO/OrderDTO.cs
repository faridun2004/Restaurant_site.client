using Restaurant_site.client.Pages;

namespace Restaurant_site.client.DTO
{
    public class OrderDTO
    {
        public Guid Id { get; set; }
        public List<OrderDetailDTO>? OrderDetails { get; set; }
    }
}
