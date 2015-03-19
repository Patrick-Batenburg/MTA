using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = 
            { "Milk", "Bread", "Bucket", "Chocolate", "Water", "Coke", "Hamburger", "Chicken", "Wood", "Plank", "Metal", "Cloth", 
            "Boots", "Shirt", "Hat", "Hood", "Cape", "Beam", "Chair", "Table", "Candy", "Bookcase", "Bed", "Chest", "Meat", "Book", "Cake" };
            LinkedList<string> list = new LinkedList<string>(products);
            while (true)
            {
                string input = Console.ReadLine();
                bool isValid = false;
            
                foreach (string str in products)
                {
                    if (input == str)
                    {
                        isValid = true;
                    }
                }
                if (isValid)
                {
                    Console.WriteLine("Product name is valid.");
                }
                else if (input == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Product name is invalid.");
                }
            }
            Console.ReadKey();
        }
    }
}
