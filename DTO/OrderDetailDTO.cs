namespace Restaurant_site.client.DTO
{
    public class OrderDetailDTO
    {
        public Guid Id { get; set; }
        public ProductDTO? Product { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        //public decimal TotalPrice { get; set; }
        public CustomerDTO? Customer { get; set; }
        public Guid CustomerId { get; set; }
        public TableDTO? Table { get; set; }
        public Guid TableId { get; set; }
        public EmployeeDTO? Employee { get; set; }
        public Guid EmployeeId { get; set; }
        public OrderDTO? Order { get; set; }
        public Guid OrderId { get; set; }
        public OrderStatus? status { get; set; }
        public DateTime CretionalDate { get; internal set; } = DateTime.Now;
        public DateTime EditDate { get; internal set; }
    }
}
