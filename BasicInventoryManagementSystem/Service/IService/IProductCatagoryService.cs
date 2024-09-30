using BasicInventoryManagementSystem.Mapper.ProductAndCatagoryMapper;
using BasicInventoryManagementSystem.Models;

namespace BasicInventoryManagementSystem.Service.IService
{
    public interface IProductCatagoryService
    {
        public string DeleteProductCatagoryService(String id);
        public ProductCatagory UpdateProductCatagoryService(ProductCatagoryMapper productCatagoryMapper, String id);
        List<ProductCatagory> GetProductCatagoryService();
        public void productCatagory(ProductCatagory productCatagory);
    }
}
