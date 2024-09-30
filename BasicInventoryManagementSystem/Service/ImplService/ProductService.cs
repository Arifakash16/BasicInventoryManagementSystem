using BasicInventoryManagementSystem.Mapper.ProductAndCatagoryMapper;
using BasicInventoryManagementSystem.Models;
using BasicInventoryManagementSystem.Repository.IRepository;
using BasicInventoryManagementSystem.Service.IService;
using System.Text;

namespace BasicInventoryManagementSystem.Service.ImplService
{
    public class ProductService : IProductService
    {
        public readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        // insert productCatagory
        public void CreateProduct(Product product)
        {
            _productRepository.CreateProduct(product);
        }




        // gell all productCatagory
        public List<Product> GetProduct(string id)
        {
            List<Product> products = _productRepository.GetProduct(id);
            return products;
        }




        // update productCatagory
        public Product UpdateProduct(Product product, String id, int pId)
        {
            Product updatedProduct = _productRepository.UpdateProduct(product, id, pId);

            return updatedProduct;
        }

        // update productCatagory
        public string DeleteProduct(int id)
        {
            return _productRepository.DeleteProduct(id);
        }

        public ProductCatagory UpdateProduct(ProductCatagoryMapper productCatagoryMapper, string id)
        {
            throw new NotImplementedException();
        }

        public List<ProductCatagory> UpdateProduct()
        {
            throw new NotImplementedException();
        }

       
    }
}
