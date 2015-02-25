using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSwitch(10, 20, '+');
        }

        public static void TestSwitch(int op1, int op2, char opr)
        {
            int result;
            switch (opr)
            {
                case '+':
                    result = op1 + op2;
                    break;
                case '-':
                    result = op1 - op2;
                    break;
                case '*':
                    result = op1 * op2;
                    break;
                case '/':
                    result = op1 / op2;
                    break;
                default:
                    Console.WriteLine("Unkown Operator");
              return;
            }
            Console.WriteLine("Result: {0}", result);
            return;

        }
    }
}
