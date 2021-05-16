using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
       {
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(f1(x));
        }

        static int f1(int x)
        {
            // x = 0 or 1 f(x) = x + 1
            // x > 1      f(x) = f(x - 1) + f(x / 2)

            return x = (x > 1) ? f1((x - 1)) + f1(x / 2) : x += 1;

            //switch (x.ToString())
            //{
            //    case "1":
            //    case "0":
            //       return x += 1;
            //    default:
            //        t1 = x - 1;
            //        t2 = x / 2;
            //        return f1(t1) + f1(t2);
            //}
        }
    }
}
