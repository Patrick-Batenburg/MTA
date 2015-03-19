using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            ExceptionTest();
            Console.ReadKey();
        }

        private static void ExceptionTest()
        {
            StreamReader sr = null;
            try
            {
                sr = File.OpenText(@"c:\data.txt");
                Console.WriteLine(sr.ReadToEnd());
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
