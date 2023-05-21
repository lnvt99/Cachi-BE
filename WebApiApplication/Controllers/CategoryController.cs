using Entity.Models;
using Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service;
using Service.Interface;
using Entity.Entity.Category;

namespace WebApiApplication.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class CategoryController : Controller
    {
        public ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        /// <summary>
        /// Get all category
        /// </summary>
        /// <returns></returns>
        [HttpGet("/get-category-list")]
        public List<ResponseGetAllCategory> GetAllBills()
        {
            List<ResponseGetAllCategory> data = _categoryService.GetAllCategory().Result;
            try
            {
                return data;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
