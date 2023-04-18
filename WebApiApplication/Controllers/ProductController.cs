using Entity.Entity.Material;
using Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service;
using Service.Interface;
using Entity.Models;

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
        [HttpGet("/getAllProduct")]
        public ResponseBody<List<Product>> GetAllProduct()
        {
            List<Product> data = _productService.getAllProduct().Result;
            try
            {
                return new ResponseBody<List<Product>>
                {
                    Status = "",
                    Data = data,
                    Message = ""
                };
            }
            catch (Exception e)
            {
                return new ResponseBody<List<Product>>
                {
                    Status = "",
                    Message = e.Message
                };
            }
        }

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
