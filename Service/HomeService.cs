using Database;
using Entity;
using Entity.Model;
using Microsoft.EntityFrameworkCore;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class HomeService : IHomeService
    {
        private readonly SettingDbContext _context;

        public HomeService( SettingDbContext context) {
            _context = context;
        }

        /// <summary>
        /// Testing Home function
        /// </summary>
        /// <returns></returns>
        public string TestingService()
        {
            string strData = "Hello ASP.NET Web API!";
            return strData;
        }

        /// <summary>
        /// Get All Data
        /// </summary>
        /// <returns></returns>
        public async Task<List<ExampleModel>> GetAllItem()
        {
            List<ExampleModel> examples = await _context.ExampleModels.ToListAsync();
            return examples;
        }

        /// <summary>
        /// Get Item By Id
        /// params Id
        /// </summary>
        /// <returns></returns>
        public async Task<ExampleModel> GetItemById(string id)
        {
            ExampleModel example = await _context.ExampleModels.FirstOrDefaultAsync(x => x.Id == id);
            return example;
        }

        public async Task<ExampleModel> CreateItem(ExampleModel exampleModel)
        {
             ExampleModel example = new ExampleModel() { 
                Id = exampleModel.Id,
                String = exampleModel.String,
                Number = exampleModel.Number,
                Boolean = exampleModel.Boolean,
                Date = exampleModel.Date
            };
            _context.ExampleModels.Add(example);
            _context.SaveChanges();
            return example;
        }

        public async Task<ExampleModel> DeleteItem(string id)
        {
            ExampleModel example = await _context.ExampleModels.FirstOrDefaultAsync(x => x.Id == id);
            _context.ExampleModels.Remove(example);
            _context.SaveChanges();
            return example;
        }

        public Task<ExampleModel> EditItem(string id)
        {
            throw new NotImplementedException();
        }
    }
}
