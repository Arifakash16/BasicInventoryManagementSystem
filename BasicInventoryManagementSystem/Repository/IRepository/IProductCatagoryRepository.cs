using BasicInventoryManagementSystem.Mapper.ProductAndCatagoryMapper;
using BasicInventoryManagementSystem.Models;

namespace BasicInventoryManagementSystem.Repository.IRepository
{
    public interface IProductCatagoryRepository
    {
        public string DeleteProductCatagoryRepository(String id);
        public ProductCatagory UpdateProductCatagoryRepository(ProductCatagoryMapper productCatagoryMapper, String id);
        List<ProductCatagory> GetProductCatagoryRepository();
        public void productCatagory(ProductCatagory productCatagory);
    }
}
