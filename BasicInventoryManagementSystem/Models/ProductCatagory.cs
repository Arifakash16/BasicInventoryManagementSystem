using System.ComponentModel.DataAnnotations;

namespace BasicInventoryManagementSystem.Models
{
    public class ProductCatagory
    {

        [Key]    
        public string ProductCatagoryId { get; set; } // Primary key

        [Required]
        public string Name { get; set; } // Name of the ProductCategory

        [Required]
        public string IsActive { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    }
}
