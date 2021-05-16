using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int i = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int j = 1; j <= i; j++)
            {
                if (j % 3 == 0)
                {
                    sum += j;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
