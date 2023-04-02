using Microsoft.AspNetCore.Mvc;

namespace WebApiApplication.Controllers
{
    public class RecipeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
