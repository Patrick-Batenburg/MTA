using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2_3
{
    
    class Program
    {
        public static void Main(string[] args)
        {
            int arrayI = 0;
            int arrayCollection1 = 10;
            Random rnd = new Random();
            Queue<Compare> list = new Queue<Compare>();
            for (int i = 0; i < arrayCollection1; i++)
                list.Enqueue(new Compare(rnd.Next(0, 50)));

            Console.WriteLine("Current values:");
            foreach (Compare p in list)
            Console.WriteLine(p.GetValue);
            Console.WriteLine();

            //IEnumerable<Compare> query = list.OrderBy( > );
            list.OrderBy(a => a, );

            Console.WriteLine("Sorted values:");
            foreach (Compare p in list)
            Console.WriteLine(p.GetValue);

            Console.ReadKey();

        }
    }
}
