using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            string[] temp = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(temp[0]);
            int b = Convert.ToInt32(temp[1]);
            int t;
            while (a != 0 && b != 0)
            {
                t = a;
                a = a % b;
                b = b % t;
            }
            Console.WriteLine(a + b);
        }
    }
}
