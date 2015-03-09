using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyA.Orders;

namespace CompanyA.OrderEntry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Product Id: ");
            string id = Console.ReadLine();
            Console.WriteLine("The Product Id is {0}", OrderValidation.IsProductIdValid(id) ? "valid" : "invalid");
            Console.ReadKey();
        }
    }
}
