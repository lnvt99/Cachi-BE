using Database;
using Entity.Entity.Category;
using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Service
{
    public class CategoryService : ICategoryService
    {
        private readonly SettingDbContext _settingDBContext;

        public CategoryService(SettingDbContext settingDBContext)
        {
            _settingDBContext = settingDBContext;
        }
        public async Task<List<ResponseGetAllCategory>> GetAllCategory()
        {
            List<Category> lstCategory = await _settingDBContext.Category.ToListAsync();
            List<ResponseGetAllCategory> data = new List<ResponseGetAllCategory>();
            lstCategory.ForEach(x =>
            {
                ResponseGetAllCategory item = new ResponseGetAllCategory();
                item.CategoryId = x.CategoryId;
                item.CategoryName = x.CategoryName;
                item.image = "";
                data.Add(item);
            });
            return data;
        }
    }
}
