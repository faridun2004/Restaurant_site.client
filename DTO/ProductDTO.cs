using Restaurant_site.client.DTO.Enums;

namespace Restaurant_site.client.DTO
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public decimal Price { get; set; }
        public ProductStatus Status { get; set; }
        public ProductType ProductType { get; set; }
        public int ProductCategoryId { get; set; } // Foreign Key
        public ProductCategory ProductCategory { get; set; }
    }
}
