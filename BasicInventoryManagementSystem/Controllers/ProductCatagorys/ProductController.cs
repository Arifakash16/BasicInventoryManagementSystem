using BasicInventoryManagementSystem.Mapper.ProductAndCatagoryMapper;
using BasicInventoryManagementSystem.Models;
using BasicInventoryManagementSystem.Service.IService;
using Microsoft.AspNetCore.Mvc;

namespace BasicInventoryManagementSystem.Controllers.ProductCatagorys
{
    [Route("product")]
    public class ProductController : Controller
    {
        public readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;

        }



        [HttpGet("[action]/{id}")]
        public IActionResult CreateProduct(string id)
        {
            return View();
        }

        // create productCatagory
        // http://localhost:2038/product/create

        [HttpPost("[action]/{id}")]
        public IActionResult CreateProduct(Product product,string id)
        {
            ViewBag.ProductCategoryId = id;
            product.ProductCategoryId = id;
            _productService.CreateProduct(product);
            return RedirectToAction("GetProduct", new { id = id });
           // return View();
        }




        //// get all productCatagory
        //// http://localhost:2038/productcatagory/get

        [HttpGet("[action]/{id}")]
        public IActionResult GetProduct(string id)
        {
            List<Product> getAllProductCatagories = _productService.GetProduct(id);
            var data = getAllProductCatagories;
            return View(data);

        }



        [HttpGet("[action]/{id}/{pId}")]
        public IActionResult UpdateProduct(string id,int pId)
        {
            return View();
        }


        // updated productCatagory
        // http://localhost:2038/productcatagory/update/{id}

        [HttpPost("[action]/{id}/{pId}")]
        public IActionResult UpdateProduct(Product product, String id,int pId)
        {
            ViewBag.ProductCategoryId = id;
            Product updateProducts = _productService.UpdateProduct(product, id, pId);
            return RedirectToAction("GetProduct");
        }





        // deleted productCatagory
        // http://localhost:2038/productcatagory/delete/{id}

        [HttpGet("[action]/{id}/{pId}")]
        public IActionResult DeleteProduct(String id,int pId)
        {
            string deletedProduct = _productService.DeleteProduct(pId);
            //return Ok(deletedProductCatagories);
            return RedirectToAction("GetProduct", new { id = id });
        }


    }
}
