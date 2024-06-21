namespace Restaurant_site.client.DTO
{
    public class OrderDTO
    {
        public Guid Id { get; set; }
        public List<OrderDetailDTO>? OrderDetails { get; set; }=new List<OrderDetailDTO>();
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public decimal TotalPrice { get; set; }
    }
}
