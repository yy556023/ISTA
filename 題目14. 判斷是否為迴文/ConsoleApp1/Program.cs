using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            string inp = Console.ReadLine();
            int x = inp.Length;
            string[] Arr = new string[x];
            string msg = string.Empty;

            //字串依序讀進陣列
            for (int i = 0; i < x; i++)
            {
                Arr[i] = inp.Trim().Substring(i, 1);
            }

            for (int i = 0; i < x; i++)
            {
                if (Arr[i] != Arr[x - 1 - i]) 
                {
                    msg = "NO";
                    break;
                }
                else
                {
                    msg = "YES";
                }
            }
            Console.WriteLine(msg);
        }
    }
}
