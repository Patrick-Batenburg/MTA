using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyA;

namespace CompanyA.Orders
{
    public static class OrderValidation
    {
        public static bool IsProductIdValid(string id)
        {
            if (id.Length == 3 && id.StartsWith("Z"))
                return true;
            else
                return false;
        }
    }
}
