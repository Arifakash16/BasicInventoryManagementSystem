using BasicInventoryManagementSystem.Mapper.ProductAndCatagoryMapper;
using BasicInventoryManagementSystem.Models;
using BasicInventoryManagementSystem.Service.IService;
using Microsoft.AspNetCore.Mvc;

namespace BasicInventoryManagementSystem.Controllers.ProductCatagorys
{
    [Route("productcatagory")]
    [ApiController]
    public class ProductCatagoryController : Controller
    {
        public readonly IProductCatagoryService _productCatagoryService;

        public ProductCatagoryController(IProductCatagoryService productCatagoryService)
        {
            _productCatagoryService = productCatagoryService;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult CreateProductCategories()
        {
            return View();
        }

        // create productCatagory
        // http://localhost:2038/productcatagory/create
        [HttpPost]
        public IActionResult ICreateProductCategories(ProductCatagory productCatagory)
        {
            //ProductCatagory productCatagory = new ProductCatagory();

            //productCatagory.Name = productCatagoryMapper.Name;
            //productCatagory.IsActive = productCatagoryMapper.IsActive;

            _productCatagoryService.productCatagory(productCatagory);
            return RedirectToAction("GetProductCategories");
        }

        // get all productCatagory
        // http://localhost:2038/productcatagory/get

        
        [HttpGet("get")]
        public IActionResult GetProductCategories()
        {
            List<ProductCatagory> getAllProductCatagories = _productCatagoryService.UpdateProductCatagoryService();
            //return Ok(getAllProductCatagories); // return all catagories as a JSON response
            var data = getAllProductCatagories;
            return View(data);

        }

        // updated productCatagory
        // http://localhost:2038/productcatagory/update/{id}

        [HttpPut("update/{id}")]
        public IActionResult UpdatedProductCategories(ProductCatagoryMapper productCatagoryMapper, String id)
        {
            ProductCatagory updatedProductCatagories = _productCatagoryService.UpdateProductCatagoryService(productCatagoryMapper, id);
            return Ok(updatedProductCatagories); // return all catagories as a JSON response
        }

        // deleted productCatagory
        // http://localhost:2038/productcatagory/delete/{id}

        [HttpDelete("delete/{id}")]
        public ActionResult<string> DeleteProductCatagories(String id)
        {
            string deletedProductCatagories = _productCatagoryService.DeleteProductCatagoryService(id);
            return Ok(deletedProductCatagories);
        }


    }
}
