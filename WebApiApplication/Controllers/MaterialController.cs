using Microsoft.AspNetCore.Mvc;

namespace WebApiApplication.Controllers
{
    public class MaterialController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
