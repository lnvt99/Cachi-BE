using Entity;
using Microsoft.AspNetCore.Mvc;
using Service;
using Service.Interface;
using Entity.Models;
using Microsoft.AspNetCore.Authorization;

namespace WebApiApplication.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class BillsController : Controller
    {
        public IBillsService _billService;
        public BillsController(IBillsService billsService)
        {
            _billService = billsService;
        }

        /// <summary>
        /// Get all bills
        /// </summary>
        /// <returns></returns>
        [HttpGet("/getAllBills")]
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

        /// <summary>
        /// Get bill by id
        /// </summary>
        /// <returns></returns>
        [HttpGet("/getBill/{id}")]
        public ResponseBody<Bill> GetBillById(int id)
        {
            Bill data = _billService.getBillById(id).Result;
            try
            {
                return new ResponseBody<Bill>
                {
                    Status = "",
                    Data = data,
                    Message = ""
                };
            }
            catch (Exception e)
            {
                return new ResponseBody<Bill>
                {
                    Status = "",
                    Message = e.Message
                };
            }
        }
    }
}
