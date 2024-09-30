using BasicInventoryManagementSystem.Mapper.ProductAndCatagoryMapper;
using BasicInventoryManagementSystem.Models;
using BasicInventoryManagementSystem.Repository.ImplRepository;

namespace BasicInventoryManagementSystem.Repository.IRepository
{
    public interface IProductRepository
    {
        public string DeleteProduct(int id);
        public Product UpdateProduct(Product product, String id, int pId);
        List<Product> GetProduct(string id);
        public void CreateProduct(Product product);
    }
}
