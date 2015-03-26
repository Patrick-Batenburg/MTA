using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the divide calc.");
            while (true)
            {
                decimal x;
                decimal y;
                Console.WriteLine("Enter the first set of number(s)");
                decimal.TryParse(Console.ReadLine(), out x);

                Console.WriteLine("Enter the second set of number(s)");
                decimal.TryParse(Console.ReadLine(), out y);

                try
                {
                    Console.WriteLine("Dividing {0} by {1} is {2}.", x, y, x / y);
                }
                catch (DivideByZeroException dbzex)
                {
                    Console.WriteLine(dbzex.Message);
                }
                catch (NullReferenceException nrex)
                {
                    Console.WriteLine(nrex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine("\nDo you want to continue? (y/n)");
                string answer = Console.ReadLine();
                if (answer == "n")
                {
                    break;
                }
                else if (answer == "y")
                {
                    Console.WriteLine();
                    continue;
                }
                else
                {
                    Console.WriteLine("Answer was incorrect, you will exit the program.");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
