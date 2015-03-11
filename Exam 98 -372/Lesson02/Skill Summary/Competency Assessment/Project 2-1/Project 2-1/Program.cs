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
            const int xLength = 5;
            const int yLength = 4;

            Random rnd = new Random();
            int[,] arr = new int[yLength, xLength];
            for (int y = 0; y < yLength; y++)
            {
                for (int x = 0; x < xLength; x++)
                {
                    arr[y, x] = rnd.Next(0, 50);
                }
            }
            
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

            for (int yHighest = 0; yHighest < yLength; yHighest++)
            {
                for (int xHighest = 0; xHighest < xLength; xHighest++)
                {
                    if (arr[yHighest, xHighest] > arr[yHighest, xHighest + 1])
                    {
                        int temp = arr[yHighest, xHighest];
                        arr[yHighest, xHighest] = arr[yHighest, xHighest + 1];
                        arr[yHighest, xHighest + 1] = temp;
                    }

                }
            }
            for (int iY = 0; iY < arr.Length; iY++)
            {
                Console.WriteLine(arr[]);
                for (int iX = 0; iX < arr.Length; iX++)
                {
                    Console.WriteLine(arr[]);
                }
            }
            Console.WriteLine("The highest element of row 1 is {0}", arr[]);
            Console.WriteLine("The highest element of row 2 is {0}", arr[1, 4]);
            Console.WriteLine("The highest element of row 3 is {0}", arr[2, 4]);
            Console.WriteLine("The highest element of row 4 is {0}", arr[3, 0]);

            Console.ReadKey();
        }
    }
}
