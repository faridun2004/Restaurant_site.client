using Restaurant_site.client.Pages;

namespace Restaurant_site.client.DTO
{
    public class OrderDTO
    {
        public Guid Id { get; set; }
        public List<ProductDTO>? products { get; set; }
        public CustomerDTO? customer { get; set; }
        public TableDTO? table { get; set; }
        public OrderStatus? status { get; set; }
        public DateTime CretionalDate { get; internal set; }
        public object EditDate { get; internal set; }
    }
}
