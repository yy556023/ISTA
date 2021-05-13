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
            string[] a = Console.ReadLine().Split(' ');

            double sum = Math.Pow(Convert.ToDouble(a[0]), 2) + Math.Pow(Convert.ToDouble(a[1]), 2);

            if (sum > 10000)
            {
                Console.WriteLine("outside");
            }
            else
            {
                Console.WriteLine("inside");
            }

            Console.ReadKey();
        }
    }
}
