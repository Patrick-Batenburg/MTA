using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathUtil
{
    public class RandomNumber
    {
        public int MinValue { get; set; }
        public int MaxValue { get; set; }

        public RandomNumber()
        {
            MinValue = int.MinValue;
            MaxValue = int.MinValue;
        }

        public int Get()
        {
            Random r = new Random();
            return r.Next(MinValue, MaxValue);
        }
    }
}
