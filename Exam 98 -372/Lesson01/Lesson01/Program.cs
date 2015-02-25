using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Rectangle
    {
        private double length;
        private double width;

        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value > 0.0)
                    length = value;
            }
        }
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value > 0.0)
                width = value;
            }
        }
        public double GetArea()
        {
            return length * width;
        }

        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.Length = 10.0;
            rect.Width = 20.0;
            double area = rect.GetArea();
            Console.WriteLine("Area of Rectangle: {0}", area);
        }
    }
}
