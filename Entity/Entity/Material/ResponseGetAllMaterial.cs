using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entity.Material
{
    public class ResponseGetAllMaterial
    {
        public int id { set; get; }
        public string name { set; get; }
        public decimal amount { get; set; }
    }
}
