using Microsoft.AspNetCore.Mvc;
using Service.Interface;

namespace WebApiApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillsDetailController : Controller
    {
        public IBillsDetailService _billsDetailTypeService;
        public BillsDetailController(IBillsDetailService billsDetailService)
        {
            _billsDetailTypeService = billsDetailService;
        }
    }
}
