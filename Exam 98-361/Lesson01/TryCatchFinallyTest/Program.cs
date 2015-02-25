using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFinallyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TryCatchFinallyTest();
        }
        private static void TryCatchFinallyTest()
        {
            StreamReader sr = null;
            try
            {
                sr = File.OpenText("data.txt");
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

            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }
    }
}
