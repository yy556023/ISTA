using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            string inp = Console.ReadLine();
            int len = inp.Length;
            char[] Arr = new char[len];
            //陣列用
            int i;
            //計算有幾個英文排列
            int count = 0;
            //各個字母的計次
            int[] c_cnt = new int[26];

            for (i = 0; i < len; i++)
            {
                Arr[i] = Convert.ToChar(inp.Substring(i, 1));
                if (Convert.ToInt32(Arr[i]) > 64 && Convert.ToInt32(Arr[i]) < 91)
                {
                    Arr[i] = Convert.ToChar(Convert.ToInt32(Arr[i] + 32));
                }
            }

            //紀錄字母出現次數
            for (i = 0; i < len; i++)
            {
                if (Convert.ToInt32(Arr[i]) > 96 && Convert.ToInt32(Arr[i]) < 123)
                {
                    c_cnt[Arr[i] - 97]++;
                }
                else if (Arr[i] == ' ')
                {
                    count++;
                }
            }
            count++;

            Console.WriteLine(count);

            for (i = 0; i < 26; i++)
            {
                if (c_cnt[i] != 0)
                {
                    Console.WriteLine(Convert.ToChar(i + 97) + "：" + c_cnt[i]);
                }
            }
        }
    }
}

