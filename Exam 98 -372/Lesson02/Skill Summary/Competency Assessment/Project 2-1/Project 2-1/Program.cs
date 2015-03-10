using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[4, 5]
            {
                { 9, 45, 6, 55, 96},
                { 3, 8, 46, 9, 82 },
                { 28, 36, 4, 22, 46},
                { 99, 6, 44, 5, 33},
            };
            Console.WriteLine("Records of row 1");
            Console.WriteLine(arr[0, 0]);
            Console.WriteLine(arr[0, 1]);
            Console.WriteLine(arr[0, 2]);
            Console.WriteLine(arr[0, 3]);
            Console.WriteLine(arr[0, 4]);
            Console.WriteLine();

            Console.WriteLine("Records of row 2");
            Console.WriteLine(arr[1, 0]);
            Console.WriteLine(arr[1, 1]);
            Console.WriteLine(arr[1, 2]);
            Console.WriteLine(arr[1, 3]);
            Console.WriteLine(arr[1, 4]);
            Console.WriteLine();

            Console.WriteLine("Records of row 3");
            Console.WriteLine(arr[2, 0]);
            Console.WriteLine(arr[2, 1]);
            Console.WriteLine(arr[2, 2]);
            Console.WriteLine(arr[2, 3]);
            Console.WriteLine(arr[2, 4]);
            Console.WriteLine();

            Console.WriteLine("Records of row 4");
            Console.WriteLine(arr[3, 0]);
            Console.WriteLine(arr[3, 1]);
            Console.WriteLine(arr[3, 2]);
            Console.WriteLine(arr[3, 3]);
            Console.WriteLine(arr[3, 4]);
            Console.WriteLine();

            Console.WriteLine("The highest element of row 1 is {0}", arr[0, 4]);
            Console.WriteLine("The highest element of row 2 is {0}", arr[1, 4]);
            Console.WriteLine("The highest element of row 3 is {0}", arr[2, 4]);
            Console.WriteLine("The highest element of row 4 is {0}", arr[3, 0]);

            Console.ReadKey();
        }
    }
}
