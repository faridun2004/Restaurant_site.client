namespace Restaurant_site.client.DTO
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public ICollection<ProductDTO>? Products { get; set; }
    }
}
