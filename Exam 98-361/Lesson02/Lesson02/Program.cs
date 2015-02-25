using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Polygon
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing: Polygon");
        }
    }
    class Rectangle: Polygon, IComparable
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public override void Draw()
        {
            Console.WriteLine("Drawing: Rectangle");
        }
        public double GetArea()
        {
            return Length * Width;
        }
        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;
            if (!(obj is Rectangle))
                throw new ArgumentException();
            Rectangle target = (Rectangle)obj;
            double diff = this.GetArea() - target.GetArea();
            if (diff == 0)
                return 0;
            else if (diff > 0)
                return 1;
            else return -1;
        }

        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle
                { Length = 10, Width = 20 };
            Rectangle rect2 = new Rectangle 
                { Length = 100, Width = 200 };
            Console.WriteLine(rect1.CompareTo(rect2));
        }
    }
}