using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            //-----------將陣列設定為幾行幾列設定好-----------
            string[] inp = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(inp[0]);
            int b = Convert.ToInt32(inp[1]);
            //-------------------------------------------

            //------------把輸出的陣列準備好-----------------
            string[,] oup = new string[b, a];


            //------------把輸入的字串存進oup陣列-------------
            for (int i = 0; i < a; i++)
            {
                inp = Console.ReadLine().Split(' ');

                for (int j = 0; j < inp.Length; j++)
                {
                    oup[j, i] = inp[j];
                }
            }
            //--------------------------------------------

            //-----------------反轉輸出---------------------
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    if (j == a - 1)
                    {
                        Console.WriteLine(oup[i, j]);
                    }
                    else
                    {
                        Console.Write(oup[i, j] + " ");
                    }                  
                }
            }
            Console.Read();
        }
    }
}
