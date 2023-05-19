using Entity.Entity.Category;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface ICategoryService
    {
        Task<List<ResponseGetAllCategory>> GetAllCategory();
    }
}
