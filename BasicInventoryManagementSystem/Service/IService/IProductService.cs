using BasicInventoryManagementSystem.Mapper.ProductAndCatagoryMapper;
using BasicInventoryManagementSystem.Models;

namespace BasicInventoryManagementSystem.Service.IService
{
    public interface IProductService
    {
        public string DeleteProduct(int id);
        public Product UpdateProduct(Product product, String id, int pId);
        public void CreateProduct(Product product);
        List<Product> GetProduct(string id);
       
    }
}
