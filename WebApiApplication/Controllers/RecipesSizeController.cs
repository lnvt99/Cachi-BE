using Microsoft.AspNetCore.Mvc;

namespace WebApiApplication.Controllers
{
    public class RecipesSizeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
