using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace UsingArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("Monday");
            list.Add("Tuesday");
            list.Add("Wednesday");
            list.Add("Thursday");
            list.Add("Friday");
            list.Add("Saturday");
            list.Add("Sunday");

            Console.WriteLine("Original list: ");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            list.Sort();
            Console.WriteLine("\nSorted list");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nItem Count: {0}", list.Count);
            Console.ReadKey();
        }
    }
}
