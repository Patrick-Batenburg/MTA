using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2_3
{
    public class Compare : IComparable
    {
        int Value;
        public Compare(int p)
        {
            this.Value = p;
        }
        public int CompareTo(object obj)
        {
            Compare right = obj as Compare;
            return this.Value.CompareTo(right.Value);
        }
        public int GetValue 
        { 
            get { return this.Value; } 
        }
    }
}
