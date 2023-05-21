using Entity.Entity.Material;
using Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service;
using Service.Interface;
using Entity.Models;
using Entity.Entity.Product;

namespace WebApiApplication.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class ProductController : Controller
    {

        public IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        /// <summary>
        /// Get all product
        /// </summary>
        /// <returns>200</returns>
        [HttpGet("/get-product-list-by-category-id")]
        public List<ResponseGetAllProduct> GetAllProduct()
        {
            return _productService.getAllProduct().Result;     
        }

        [HttpGet("/get-best-seller-product-list-by-category-id")]
        public List<ResponseGetAllProduct> GetAllBestProduct()
        {
            return _productService.getAllProduct().Result;
        }

        [HttpGet()]

        /// <summary>
        /// Get product by categoryId
        /// </summary>
        /// <returns>200</returns>
        [HttpGet("/getProduct/{id}")]
        public ResponseBody<Product> GetProductByCategoryId(string id)
        {
            Product data = _productService.GetProductByCategoryId(id).Result;
            try
            {
                return new ResponseBody<Product>
                {
                    Status = "",
                    Data = data,
                    Message = ""
                };
            }
            catch (Exception e)
            {
                return new ResponseBody<Product>
                {
                    Status = "",
                    Message = e.Message
                };
            }
        }
    }
}
