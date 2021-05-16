using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int[] b = new int[8];
            int i = 0;


            if (x < 0)
            {
                x += 256;                
            }
            
            while (x != 0)
            {
                b[i] = x % 2;
                x /= 2;
                i++;
            }

            Array.Reverse(b);

            foreach (int item in b)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
