using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2_3
{
    class CompareIntegers : IComparer<int>
    {
        public int Compare(int i1, int i2)
        {
            return i1 - 12;
        }
    }
}
