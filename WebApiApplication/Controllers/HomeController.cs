using Database;
using Entity;
using Entity.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Service.Interface;

namespace WebApiApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        public IHomeService _homeService;
        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }


        #region Testing web api
        /// <summary>
        /// Testing Web API
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ResponseBody<string> Get()
        {
            try
            {
                string strData = _homeService.TestingService();
                return new ResponseBody<string>
                {
                    Status = "",
                    Data = strData,
                    Message = ""
                };
            }
            catch (Exception e)
            {
                return new ResponseBody<string>
                {
                    Status = "",
                    Message = e.Message
                };
            }
        }
        #endregion

        #region CRUD Example table
        /// <summary>
        /// Get all data
        /// </summary>
        /// <returns></returns>
        [HttpGet("/getAllItem")]
        public ResponseBody<List<ExampleModel>> GetAll()
        {
            List<ExampleModel> data = _homeService.GetAllItem().Result;
            try
            {
                return new ResponseBody<List<ExampleModel>>
                {
                    Status = "",
                    Data = data,
                    Message = ""
                };
            }
            catch (Exception e)
            {
                return new ResponseBody<List<ExampleModel>>
                {
                    Status = "",
                    Message = e.Message
                };
            }
        }

        /// <summary>
        /// Get item data
        /// </summary>
        /// <returns></returns>
        [HttpGet("/getItem/{id}")]
        public ResponseBody<ExampleModel> GetItemById(string id)
        {
            ExampleModel data = _homeService.GetItemById(id).Result;
            try
            {
                return new ResponseBody<ExampleModel>
                {
                    Status = "",
                    Data = data,
                    Message = ""
                };
            }
            catch (Exception e)
            {
                return new ResponseBody<ExampleModel>
                {
                    Status = "",
                    Message = e.Message
                };
            }
        }

        /// <summary>
        /// Create item
        /// </summary>
        /// <returns></returns>
        [HttpPost]  
        public ResponseBody<ExampleModel> CreatItem(ExampleModel exampleModel)
        {
            ExampleModel newExample = _homeService.CreateItem(exampleModel).Result;
            if (newExample == null) throw new Exception();
            return new ResponseBody<ExampleModel> { 
                Status = "",
                Data = newExample,
                Message = ""
            };
        }

        /// <summary>
        /// Edit item
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public IActionResult EditItem(string id)
        {
            if (id == null) throw new ArgumentNullException("id");
            ExampleModel newExample = _homeService.EditItem(id).Result;
            if (newExample == null) return StatusCode(500);
            return Ok();
        }

        /// <summary>
        /// Delete item
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>Return status</returns>
        [HttpDelete]
        public IActionResult DeleteItem(string id)
        {
            if (id == null) throw new ArgumentNullException("id");
            ExampleModel newExample = _homeService.DeleteItem(id).Result;
            if (newExample == null) return StatusCode(500);
            return Ok();
        }
        #endregion
    }
}
