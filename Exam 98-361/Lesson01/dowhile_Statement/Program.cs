using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhile_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            DoWhileTest();
        }

        private static void DoWhileTest()
        {
            int i = 1;
            do
            {
                Console.WriteLine("The value of i = {0}", i);
                i++;
            }
            while (i <= 5);
        }
    }
}
