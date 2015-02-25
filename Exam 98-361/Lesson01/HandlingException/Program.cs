using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingException
{
    class Program
    {
        static void Main(string[] args)
        {
            ExceptionTest();
        }

        private static void ExceptionTest()
        {
            StreamReader sr = null;
            try
            {
                sr = File.OpenText(@"c:\users\Patrick\data.txt");
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
