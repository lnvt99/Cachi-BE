using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entity.Product
{
    public class ResponseGetAllProduct
    {
        public int id {  get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string price { get; set; }
        public int salesNumber { get; set; }
        public string description { get; set; }
    }
}
