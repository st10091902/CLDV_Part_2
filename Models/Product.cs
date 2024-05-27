using System.ComponentModel.DataAnnotations;

namespace CLDV_Part_2.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string Category { get; set; }

        public bool Availability { get; set; }
    }
}
