﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entity.Category
{
    public class ResponseGetAllCategory
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }

        public string image { get; set; }
    }
}
