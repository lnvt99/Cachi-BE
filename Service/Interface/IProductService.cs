using Entity.Entity.Product;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IProductService
    {
        Task<List<ResponseGetAllProduct>> getAllProduct();
        Task<Product> GetProductByCategoryId(string id);
    }
}
