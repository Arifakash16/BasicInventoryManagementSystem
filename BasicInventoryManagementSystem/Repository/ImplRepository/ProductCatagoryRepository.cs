using BasicInventoryManagementSystem.Db;
using BasicInventoryManagementSystem.Mapper.ProductAndCatagoryMapper;
using BasicInventoryManagementSystem.Models;
using BasicInventoryManagementSystem.Repository.IRepository;

namespace BasicInventoryManagementSystem.Repository.ImplRepository
{
    public class ProductCatagoryRepository : IProductCatagoryRepository
    {
        private readonly InventoryDbContext _context; // Assuming you have an ApplicationDbContext

        public ProductCatagoryRepository(InventoryDbContext context)
        {
            _context = context;
        }

        // insert productCatagory
        public void productCatagory(ProductCatagory productCatagory)
        {
            _context.ProductCatagories.Add(productCatagory);
            _context.SaveChanges();
        }

        // get all productCatagory
        public List<ProductCatagory> GetProductCatagoryRepository()
        {
            List<ProductCatagory> productCatagories = _context.ProductCatagories.ToList();
            return productCatagories;
        }

        // update productCatagory
        public ProductCatagory UpdateProductCatagoryRepository(ProductCatagoryMapper productCatagoryMapper, String id)
        {
            // fetch updated catagory
            var productCatagory = _context.ProductCatagories.FirstOrDefault(u => u.ProductCatagoryId == id);

            if (productCatagory == null)
            {
                // Handle the case where the category is not found
                throw new Exception($"Product category with ID {id} not found.");
            }
          

            // Update the existing category with new values from ProductCatagoryMapper
            productCatagory.Name = productCatagoryMapper.Name;
            productCatagory.IsActive = productCatagoryMapper.IsActive;
            productCatagory.UpdatedAt = DateTime.UtcNow;

            // Save the changes back to the database
            _context.ProductCatagories.Update(productCatagory);
            _context.SaveChanges();

            return productCatagory;
        }

        // delete productCatagory
        public string DeleteProductCatagoryRepository(String id)
        {
            var productCatagory = _context.ProductCatagories.Find(id);
            if (productCatagory == null)
            {
                return "deleted item not found"; // Not found
            }

            _context.ProductCatagories.Remove(productCatagory);
            _context.SaveChanges(); // Save changes to the database
            return "Successfully deleted";
        }
    }
}
