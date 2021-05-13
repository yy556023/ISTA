using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            
            string a = Console.ReadLine();

            for (int i = 0; i < 4; i++)
            {
                string x = a.Substring(i, 1);
                if (i == 3) 
                {
                    f1(x);
                    Console.WriteLine();
                }
                else
                {
                    f1(x);
                    Console.Write(" ");
                }
            }

            for (int i = 0; i < 4; i++)
            {
                string x = a.Substring(i, 1);
                if (i == 3)
                {
                    f2(x);
                    Console.WriteLine();
                }
                else
                {
                    f2(x);
                    Console.Write(" ");
                }
            }

            for (int i = 0; i < 4; i++)
            {
                string x = a.Substring(i, 1);
                if (i == 3)
                {
                    f3(x);
                    Console.WriteLine();
                }
                else
                {
                    f3(x);
                    Console.Write(" ");
                }
            }

            for (int i = 0; i < 4; i++)
            {
                string x = a.Substring(i, 1);
                if (i == 3)
                {
                    f4(x);
                    Console.WriteLine();
                }
                else
                {
                    f4(x);
                    Console.Write(" ");
                }
            }

            for (int i = 0; i < 4; i++)
            {
                string x = a.Substring(i, 1);
                if (i == 3)
                {
                    f5(x);
                    Console.WriteLine();
                }
                else
                {
                    f5(x);
                    Console.Write(" ");
                }
            }

            Console.ReadKey();

        }

        static void f1(string x)
        {
            if(x == "1")
            {
                Console.Write("    *");
            }
            else if (x == "4")
            {
                Console.Write("*   *");
            }
            else
            {
                Console.Write("*****");
            }
        }

        static void f2(string x)
        {
            if (x == "0" || x == "4" || x == "8" || x == "9")
            {
                Console.Write("*   *");
            }
            else if (x == "5" || x == "6" ) 
            {
                Console.Write("*    ");
            }
            else
            {
                Console.Write("    *");
            }
        }

        static void f3(string x)
        {
            if (x == "0")
            {
                Console.Write("*   *");
            }
            else if (x == "1"||x == "7")
            {
                Console.Write("    *");
            }
            else
            {
                Console.Write("*****");
            }
        }

        static void f4(string x)
        {
            if (x == "0" || x == "6" || x == "8")
            {
                Console.Write("*   *");
            }
            else if (x == "2")
            {
                Console.Write("*    ");
            }
            else
            {
                Console.Write("    *");
            }

        }

        static void f5(string x)
        {
            if (x == "1" || x == "4" || x == "7")
            {
                Console.Write("    *");
            }
            else
            {
                Console.Write("*****");
            }
        }
    }
}

//*****     * ***** ***** *   * ***** ***** ***** ***** *****
//*   *     *     *     * *   * *     *         * *   * *   *
//*   *     * ***** ***** ***** ***** *****     * ***** *****
//*   *     * *         *     *     * *   *     * *   *     *
//*****     * ***** *****     * ***** *****     * ***** *****

