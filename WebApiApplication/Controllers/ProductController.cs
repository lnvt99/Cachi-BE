using Microsoft.AspNetCore.Mvc;

namespace WebApiApplication.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
