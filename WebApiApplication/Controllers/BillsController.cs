using Entity.Model;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Service;
using Service.Interface;
using Entity.Models;

namespace WebApiApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillsController : Controller
    {
        public IBillsService _billService;
        public BillsController(IBillsService billsService)
        {
            _billService = billsService;
        }

        [HttpGet("/getAllBill")]
        public ResponseBody<List<Bill>> GetAllBills()
        {
            List<Bill> data = _billService.getAllBills().Result;
            try
            {
                return new ResponseBody<List<Bill>>
                {
                    Status = "",
                    Data = data,
                    Message = ""
                };
            }
            catch (Exception e)
            {
                return new ResponseBody<List<Bill>>
                {
                    Status = "",
                    Message = e.Message
                };
            }
        }
    }
}
