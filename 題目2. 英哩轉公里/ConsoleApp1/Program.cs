using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine()) * 1.6;

            Console.WriteLine($"{a:f1}");
            Console.ReadKey();
        }
    }
}
