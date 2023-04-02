using Microsoft.AspNetCore.Mvc;

namespace WebApiApplication.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
