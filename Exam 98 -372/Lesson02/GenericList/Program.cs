using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(2);
            numbers.AddRange(new[] { 4, 8, 10 });

            Console.WriteLine("Number of items: {0}", numbers.Count);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("List contains the number 6? {0}", numbers.Contains(6));
            numbers.Insert(2, 6);

            Console.WriteLine("Number of items: {0}", numbers.Count);
            Console.WriteLine("Item at index [2]: {0}", numbers[2]);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
