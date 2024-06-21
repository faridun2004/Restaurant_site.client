using Microsoft.AspNetCore.Http;
using Restaurant_site.client.DTO.Enums;

namespace Restaurant_site.client.DTO
{
    public class ProductCreateDto
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public IFormFile? ImageFile { get; set; }
        public decimal Price { get; set; }
        public ProductStatus? Status { get; set; }
        public ProductType? Type { get; set; }
        public int ProductCategoryId { get; set; }
    }
}
