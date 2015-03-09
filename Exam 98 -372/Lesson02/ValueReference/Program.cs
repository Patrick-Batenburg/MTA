using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueReference
{
    class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }
    }

    struct Point
    {
        public double X, Y;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Copying value type
            Point p1 = new Point();
            p1.X = 10.0;
            p1.Y = 20.0;
            Point p2 = p1;
            p2.X = 100.0;
            Console.WriteLine("p1.X = {0}", p1.X);

            // Copying reference type
            Rectangle rect1 = new Rectangle 
            { Length = 10.0, Width = 20.0 };

            Rectangle rect2 = rect1;
            rect2.Length = 100.0;

            Console.WriteLine("rect.Length = {0}", rect1.Length);
        }
    }
}
