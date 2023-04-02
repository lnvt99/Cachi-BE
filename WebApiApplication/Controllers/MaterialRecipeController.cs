using Microsoft.AspNetCore.Mvc;

namespace WebApiApplication.Controllers
{
    public class MaterialRecipeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
