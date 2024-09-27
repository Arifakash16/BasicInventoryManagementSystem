using System.ComponentModel.DataAnnotations;

namespace BasicInventoryManagementSystem.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; } // Primary key

        [Required]
        public string Name { get; set; } // Name of the product
        public string Description { get; set; } // Optional description of the product

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "The price must be greater than zero.")]
        public decimal Price { get; set; } // Product price

        [Required]
        public int StockQuantity { get; set; } // Available stock quantity

        [Required]
        public string ProductCategoryId { get; set; } // Foreign key to ProductCategory

        public ProductCatagory ProductCategory { get; set; } // Navigation property for ProductCategory

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Timestamp for creation

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow; // Timestamp for last update
    }
}
