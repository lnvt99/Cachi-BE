using Entity.Models;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ProductService : IProductService
    {
        public Task<List<Product>> getAllProduct()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProductByCategoryId(string id)
        {
            throw new NotImplementedException();
        }
    }
}
