using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse_Statement
{
    class program
    {
        static void Main(string[] args)
        {
            TestIfElse(10);
        }

        public static void TestIfElse (int n)
        {
            if (n < 10)
            {
                Console.WriteLine("n is less than 10");
            }

            else if (n < 20)
            {
                Console.WriteLine("n is less than 20");
            }

            else if (n < 30)
            {
                Console.WriteLine("n is less than 30");
            }

            else
            {
                Console.WriteLine("n is greater or equal to 30");
            }
        }


    }
}
