using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_3
{
    public class ObjectProduct
    {
        private object value;

        public ObjectProduct(object value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }

    public class ProductEx
    {
        public static void Main()
        {
            ObjectProduct objP = new ObjectProduct("Product name: Meth \nPrice: $2,75");
            Console.WriteLine(objP.ToString());
            Console.ReadKey();
        }
    }
}
