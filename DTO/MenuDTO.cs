namespace Restaurant_site.client.DTO
{
    public class MenuDTO
    {
        public Guid Id { get; set; }
        public List<ProductDTO>? Products { get; set; }
    }
}
