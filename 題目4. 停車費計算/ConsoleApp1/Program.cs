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
                string[] a = Console.ReadLine().Split(' ');
                string[] b = Console.ReadLine().Split(' ');

                int[] c = new int[3];
                int sum = 0;


                for (int i = 0; i < a.Length; i++)
                {
                    c[i] = Int32.Parse(b[i]) - Int32.Parse(a[i]);
                }

                c[2] = c[0] * 60 + c[1];

                if (c[2] > 240)
                {
                    sum = 280 + (c[2] / 30 - 8) * 60;
                }
                else if (c[2] > 120)
                {
                    sum = 120 + (c[2] / 30 - 4) * 40;
                }
                else 
                {
                    sum = (c[2] / 30) * 30;
                }

                Console.WriteLine(sum);
                //Main();
            }
        }   
    }

