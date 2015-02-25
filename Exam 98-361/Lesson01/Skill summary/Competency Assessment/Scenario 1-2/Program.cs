using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;

            if (n > 1)
            {
                n = 1 * n;
                n = n - 1;
            }

            else
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }
}
