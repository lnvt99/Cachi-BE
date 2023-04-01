using Entity;
using Microsoft.AspNetCore.Mvc;
using Service;
using Service.Interface;
using Entity.Models;
using Entity.Models.Bills;

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

        /// <summary>
        /// Get all bills
        /// </summary>
        /// <returns></returns>
        [HttpGet("/getAllBills")]
        public ResponseBody<List<BillsModel>> GetAllBills()
        {
            List<BillsModel> data = _billService.getAllBills().Result;
            try
            {
                return new ResponseBody<List<BillsModel>>
                {
                    Status = "",
                    Data = data,
                    Message = ""
                };
            }
            catch (Exception e)
            {
                return new ResponseBody<List<BillsModel>>
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
        public ResponseBody<BillsModel> GetBillById(int id)
        {
            BillsModel data = _billService.getBillById(id).Result;
            try
            {
                return new ResponseBody<BillsModel>
                {
                    Status = "",
                    Data = data,
                    Message = ""
                };
            }
            catch (Exception e)
            {
                return new ResponseBody<BillsModel>
                {
                    Status = "",
                    Message = e.Message
                };
            }
        }
    }
}
