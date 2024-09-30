using BasicInventoryManagementSystem.Db;
using BasicInventoryManagementSystem.Mapper.ProductAndCatagoryMapper;
using BasicInventoryManagementSystem.Models;
using BasicInventoryManagementSystem.Repository.IRepository;

namespace BasicInventoryManagementSystem.Repository.ImplRepository
{
    public class ProductRepository: IProductRepository
    {
        private readonly InventoryDbContext _context; // Assuming you have an ApplicationDbContext

        public ProductRepository(InventoryDbContext context)
        {
            _context = context;
        }

        // insert product
        public void CreateProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        // get all productCatagory
        public List<Product> GetProduct(string id)
        {
            List<Product> products = _context.Products
                                     .Where(p => p.ProductCategoryId == id)
                                     .ToList();
            return products;
        }

        // update productCatagory
        public Product UpdateProduct(Product product, String id, int pId)
        {

            // fetch updated catagory
            var updatedProduct = _context.Products.FirstOrDefault(p => p.ProductCategoryId == id && p.Id == pId);

            if (updatedProduct == null)
            {
                // Handle the case where the category is not found
                throw new Exception($"Product category with ID {id} not found.");
            }


            // Update the existing category with new values from ProductCatagoryMapper
            updatedProduct.Name = product.Name;
            updatedProduct.Description = product.Description;
            updatedProduct.Price = product.Price;
            updatedProduct.StockQuantity = product.StockQuantity;
            updatedProduct.UpdatedAt = DateTime.UtcNow;

            // Save the changes back to the database
            _context.Products.Update(updatedProduct);
            _context.SaveChanges();

            return updatedProduct;
        }

        // delete productCatagory
        public string DeleteProduct(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return "deleted item not found"; // Not found
            }

            _context.Products.Remove(product);
            _context.SaveChanges(); // Save changes to the database
            return "Successfully deleted";
        }

    }
}
