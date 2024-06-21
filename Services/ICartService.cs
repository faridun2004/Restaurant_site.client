using Restaurant_site.client.DTO;

namespace Restaurant_site.client.Services
{
    public interface ICartService
    {
        Task<Cart> GetCart();
        Task AddToCart(CartItem item);
        Task RemoveFromCart(int productId);
        Task ClearCart();
        Task UpdateQuantity(int productId, int newQuantity);
    }
}
