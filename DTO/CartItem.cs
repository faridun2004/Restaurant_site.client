using System.ComponentModel.DataAnnotations;

namespace Restaurant_site.client.DTO
{
    public class CartItem
    {
        [Key]
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int CartItemId { get; internal set; }
    }
}
