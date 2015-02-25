using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Discount1(100);
            Discount2(100);
            Discount3(100);
            Discount4(10);
            Console.ReadKey();
        }

        public static void Discount1(int q = 100)
        {
            if (q <= 100)
            {
                Console.WriteLine("Discount 5%");
            }

            else
            {
                Console.WriteLine("Quantity value is unkown");
            }
        }

        public static void Discount2(int q = 100)
        {
            if (q == 100 & q <= 100)
            {
                Console.WriteLine("Discount 10%");
            }

            else
            {
                Console.WriteLine("Quantity value is unkown");
            }
        }

        public static void Discount3(int q = 100)
        {
            if (q == 100 & q <= 100)
            {
                Console.WriteLine("Discount 15%");
            }

            else
            {
                Console.WriteLine("Quantity value is unkown");
            }
        }

        public static void Discount4(int q = 10)
        {
            if (q <= 10)
            {
                Console.WriteLine("Discount 20%");
            }

            else
            {
                Console.WriteLine("Quantity value is unkown");
            }
        }
    }
}
