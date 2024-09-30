using BasicInventoryManagementSystem.Mapper.ProductAndCatagoryMapper;
using BasicInventoryManagementSystem.Models;
using BasicInventoryManagementSystem.Repository.IRepository;
using BasicInventoryManagementSystem.Service.IService;
using System.Security.Cryptography;
using System.Text;

namespace BasicInventoryManagementSystem.Service.ImplService
{
    public class ProductCatagoryService : IProductCatagoryService
    {
        public readonly IProductCatagoryRepository _productCatagoryRepository;

        public ProductCatagoryService(IProductCatagoryRepository productCatagoryrepository)
        {
            _productCatagoryRepository = productCatagoryrepository;
        }

        // insert productCatagory
        public void productCatagory(ProductCatagory productCatagory)
        {
            //generate hashvalue for productCatagoryId 
            String productCataId;
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(productCatagory.Name));
                // Convert to hex and take first 10 characters
                string hash = BitConverter.ToString(bytes).Replace("-", "").ToLowerInvariant();
                productCataId = hash.Substring(0, 10); // Return the first 10 characters
            }

            // assign productCatagoryId
            productCatagory.ProductCatagoryId = productCataId;

            // data is send to the repository layer
            _productCatagoryRepository.productCatagory(productCatagory);
        }

        // gell all productCatagory
        public List<ProductCatagory> GetProductCatagoryService()
        {
            List<ProductCatagory> productCatagories = _productCatagoryRepository.GetProductCatagoryRepository();
            return productCatagories;
        }

        // update productCatagory
        public ProductCatagory UpdateProductCatagoryService(ProductCatagoryMapper productCatagoryMapper,String id)
        {
            ProductCatagory productCatagori = _productCatagoryRepository.UpdateProductCatagoryRepository(productCatagoryMapper, id);

            return productCatagori;
        }

        // update productCatagory
        public string DeleteProductCatagoryService(String id)
        {
            return _productCatagoryRepository.DeleteProductCatagoryRepository(id);
        }
    }
}
