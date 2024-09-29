using BasicInventoryManagementSystem.Db;
using BasicInventoryManagementSystem.Mapper.ProductAndCatagoryMapper;
using BasicInventoryManagementSystem.Models;
using BasicInventoryManagementSystem.Service.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BasicInventoryManagementSystem.Controllers.ProductCatagorys
{
    [Route("productcatagory")]
    public class ProductCatagoryController : Controller
    {


        public readonly IProductCatagoryService _productCatagoryService;

        public ProductCatagoryController(IProductCatagoryService productCatagoryService)
        {
            _productCatagoryService = productCatagoryService;
           
        }



        [HttpGet("create")]
        public IActionResult CreateProductCategories()
        {
            return View();
        }



        // create productCatagory
        // http://localhost:2038/productcatagory/create

        [HttpPost("create")]
        public IActionResult CreateProductCategories(ProductCatagoryMapper productCatagoryMapper)
        {
            ProductCatagory productCatagory = new ProductCatagory();
            
            productCatagory.Name = productCatagoryMapper.Name;
            productCatagory.IsActive = productCatagoryMapper.IsActive;

            _productCatagoryService.productCatagory(productCatagory);
            return RedirectToAction("GetProductCategories");
        }




        // get all productCatagory
        // http://localhost:2038/productcatagory/get

        [HttpGet("get")]
        public IActionResult GetProductCategories()
        {
            List<ProductCatagory> getAllProductCatagories = _productCatagoryService.UpdateProductCatagoryService();
            var data = getAllProductCatagories;
            return View(data);

        }



        [HttpGet("[action]/{id}")]
        public IActionResult UpdatedProductCategories(string id)
        {
            return View();
        }


        // updated productCatagory
        // http://localhost:2038/productcatagory/update/{id}

        [HttpPost("[action]/{id}")]
        public IActionResult UpdatedProductCategories(ProductCatagoryMapper productCatagoryMapper, String id)
        {
            ProductCatagory updatedProductCatagories = _productCatagoryService.UpdateProductCatagoryService(productCatagoryMapper, id);
            return RedirectToAction("GetProductCategories");
        }



        

        // deleted productCatagory
        // http://localhost:2038/productcatagory/delete/{id}

        [HttpGet("[action]/{id}")]
        public IActionResult DeleteProductCatagories(String id)
        {
            string deletedProductCatagories = _productCatagoryService.DeleteProductCatagoryService(id);
            //return Ok(deletedProductCatagories);
            return RedirectToAction("GetProductCategories");
        }


    }
}
