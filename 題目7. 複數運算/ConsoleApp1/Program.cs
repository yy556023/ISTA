using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int x = Convert.ToInt32(Console.ReadLine());

            string[][] a = new string[x][];
            double t1,t2,t3,t4;


            for (int i = 0; i < x; i++) 
            {
                a[i] = new string[5];
                a[i] = Console.ReadLine().Split(' ');
            }

            for (int i = 0; i < x; i++)
            {
                switch (a[i][0])
                {
                    case "+":
                        t1 = Convert.ToDouble(a[i][1]);
                        t2 = Convert.ToDouble(a[i][2]);
                        t3 = Convert.ToDouble(a[i][3]);
                        t4 = Convert.ToDouble(a[i][4]);
                        
                        Console.WriteLine((t1 + t3) + " " + (t2 + t4));

                        break;
                    case "-":
                        t1 = Convert.ToDouble(a[i][1]);
                        t2 = Convert.ToDouble(a[i][2]);
                        t3 = Convert.ToDouble(a[i][3]);
                        t4 = Convert.ToDouble(a[i][4]);

                        Console.WriteLine((t1 - t3) + " " + (t2 - t4));

                        break;
                    case "*":
                        t1 = Convert.ToDouble(a[i][1]);
                        t2 = Convert.ToDouble(a[i][2]);
                        t3 = Convert.ToDouble(a[i][3]);
                        t4 = Convert.ToDouble(a[i][4]);

                        double temp1 = t1 * t3 - t2 * t4;
                        double temp2 = t2 * t3 + t1 * t4;

                        Console.WriteLine(temp1 + " " + temp2);

                        break;
                    case "/":
                        t1 = Convert.ToDouble(a[i][1]);
                        t2 = Convert.ToDouble(a[i][2]);
                        t3 = Convert.ToDouble(a[i][3]);
                        t4 = Convert.ToDouble(a[i][4]);

                        double temp3 = t1 * t3 - t2 * t4;
                        double temp4 = t2 * t3 + t1 * t4;
                        double temp5 = Math.Pow(t3, 2) + Math.Pow(t4, 2);

                        Console.WriteLine(temp3 / temp5 + " " + temp4 / temp5);

                        break;
                }
            }

            Console.ReadKey();

        }

    }
}
