using BasicInventoryManagementSystem.Mapper.ProductAndCatagoryMapper;
using BasicInventoryManagementSystem.Models;

namespace BasicInventoryManagementSystem.Repository.IRepository
{
    public interface IProductCatagoryRepository
    {
        public string deleteProductCatagoryRepository(String id);
        public ProductCatagory UpdateProductCatagoryRepository(ProductCatagoryMapper productCatagoryMapper, String id);
        List<ProductCatagory> GetProductCatagoryRepository();
        public void productCatagory(ProductCatagory productCatagory);
    }
}
