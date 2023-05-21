using Database;
using Entity.Entity.Category;
using Entity.Entity.Product;
using Entity.Models;
using Microsoft.EntityFrameworkCore;
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
        private readonly SettingDbContext _settingDBContext;

        public ProductService(SettingDbContext settingDBContext)
        {
            _settingDBContext = settingDBContext;
        }
        public async Task<List<ResponseGetAllProduct>> getAllProduct()
        {
            List<Product> lstCategory = await _settingDBContext.Products.ToListAsync();
            List<ResponseGetAllProduct> data = new List<ResponseGetAllProduct>();
            lstCategory.ForEach(x =>
            {
                ResponseGetAllProduct item = new ResponseGetAllProduct();
                item.id = x.ProductId;
                item.name = x.ProductName;
                item.image = "https://cdn.quasar.dev/img/chicken-salad.jpg";
                item.price = x.Price.ToString();
                item.salesNumber = 1000;
                item.description = "Small plates, salads & sandwiches in an intimate setting.";
                data.Add(item);
            });
            return data;
        }

        public Task<Product> GetProductByCategoryId(string id)
        {
            throw new NotImplementedException();
        }
    }
}
