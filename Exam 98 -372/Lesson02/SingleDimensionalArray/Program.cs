using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[4] { 11, 7, 50, 45 };
            Console.WriteLine("Array items: ");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nMax number: {0}", numbers.Max());

            Console.WriteLine("\nArray items in reverse: ");
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadKey();
        }
    }
}
