using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var process1 = new Process())
            {
                process1.StartInfo.FileName = @"..\..\..\RentingHouse\bin\Debug\RentingHouse.exe";
                process1.Start();
            }

            using (var process2 = new Process())
            {
                process2.StartInfo.FileName = @"..\..\..\RentingHouse\bin\Debug\RentingHouse.exe";
                process2.Start();
            }

            Console.WriteLine("MainApp");
            Console.ReadKey();
        }
    }
}
