using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AppConfig
{
    class Program
    {
        static void Main(string[] args)
        {
            string logFile = ConfigurationManager.AppSettings["LogFile"];
            string adminEmail = ConfigurationManager.AppSettings["AdminEmail"];
            string connString = ConfigurationManager.ConnectionStrings["prodServer"].ConnectionString;
            Console.WriteLine("LogFile: {0}", logFile);
            Console.WriteLine("AdminEmail: {0}", adminEmail);
            Console.WriteLine("connection string: {0}", connString);
            Console.ReadKey();
        }
    }
}
