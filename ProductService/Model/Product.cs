using System.ComponentModel.DataAnnotations;

namespace ProductService.Model
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public decimal Price { get; set; }

    }
}
