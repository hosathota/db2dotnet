using System;
using IBM.Data.DB2.Core;
using System.IO;
using System.Threading;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Db2 .NET from OC 09");
            System.Diagnostics.Process.Start("CMD.exe", "sudo yum install libxml2");
            Thread.Sleep(8000);
            
            Console.WriteLine("Current directory is "+Directory.GetCurrentDirectory());
            try
            {
                DB2Connection conn = new DB2Connection("DATABASE=SomeDb;server=yourserver:50000;UID=myuserid;PWD=testpwd;");
                conn.Open();
                Console.WriteLine("Connection Open and connected to server version "+conn.ServerVersion);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Db2 Connection Error "+ex.Message);
            }
            Console.WriteLine("Complete");
        }
    }
}
