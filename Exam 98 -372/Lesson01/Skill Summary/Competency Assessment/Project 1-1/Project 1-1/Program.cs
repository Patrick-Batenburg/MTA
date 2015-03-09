using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Product Id: ");
            string id = Console.ReadLine();
            Console.WriteLine("The Product Id is {0}", Product.ProductName(id) ? "valid" : "invalid");
            Console.ReadKey();
        }
    }
}
