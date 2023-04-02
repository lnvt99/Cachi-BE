using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class StringUtil
    {
        public bool checkNullOrEmpty(string value) { 
            bool result = false;
            if (value == null || value == "") { 
                result = true;
            }
            return result;
        }
    }
}
