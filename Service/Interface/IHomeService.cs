using Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IHomeService
    {
        /// <summary>
        /// Testing Home function
        /// </summary>
        /// <returns></returns>
        string TestingService();

        /// <summary>
        /// Get all data
        /// </summary>
        /// <returns></returns>
        Task<List<ExampleModel>> GetAllItem();

        /// <summary>
        /// Get all data
        /// </summary>
        /// <returns></returns>
        Task<ExampleModel> GetItemById(string id);

        /// <summary>
        /// Create Item
        /// </summary>
        /// <returns></returns>
        Task<ExampleModel> CreateItem(ExampleModel exampleModel);

        /// <summary>
        /// Delete Item
        /// </summary>
        /// <returns></returns>
        Task<ExampleModel> DeleteItem(string id);

        /// <summary>
        /// Edit Item
        /// </summary>
        /// <returns></returns>
        Task<ExampleModel> EditItem(string id);
    }
}
