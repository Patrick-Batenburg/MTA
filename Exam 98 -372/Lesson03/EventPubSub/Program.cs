using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPubSub
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.Changed += new EventHandler(Rectangle_Changed);
            rect.Length = 10;
            Console.ReadKey();
        }

        static void Rectangle_Changed(object sender, EventArgs e)
        {
            Rectangle rect = (Rectangle)sender;
            Console.WriteLine("Value Changed: Length = {0}", rect.Length);
        }
    }
}
