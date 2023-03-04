﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ResponseBody<T>
    {
        public string? Status { get; set; }
        public T? Data { get; set; }
        public string? Message { get; set; }

    }
}
