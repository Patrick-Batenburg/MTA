using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_1
{
    class Product
    {
        public static bool ProductName(string name)
        {
            if (name.Length == 4 && name.StartsWith("P"))
                return true;
            else
                return false;
        }
    }
}
