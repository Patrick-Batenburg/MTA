using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 12;
            string name = "Anders";

            bool IsValid = true;
            double pi = 3.141;

            Console.WriteLine("Runtime type for int: {0}", number.GetType());

            Console.WriteLine("Runtime type for string: {0}", name.GetType());

            Console.WriteLine("Runtime type for bool: {0}", IsValid.GetType());

            Console.WriteLine("Runtime type for double: {0}", pi.GetType());


        }
    }
}
