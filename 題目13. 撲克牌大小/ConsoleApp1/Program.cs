using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            //輸入有幾行
            int x = Convert.ToInt32(Console.ReadLine());
            string[] oup = new string[x];

            //花色的牌
            List<int> s = new List<int>();
            List<int> d = new List<int>();
            List<int> h = new List<int>();
            List<int> c = new List<int>();

            //重組輸入的字串
            for (int i = 0; i < x; i++)
            {
                oup[i] = Console.ReadLine();
                string[] temp = oup[i].Split(' ');
                oup[i] = "";

                //把暫存陣列的撲克牌存進各自的花色
                for (int j = 0; j < temp.Length; j++)
                {   
                    switch(temp[j].Substring(0, 1))
                    {
                        case "S":
                            s.Add(Convert.ToInt32(temp[j].Substring(1)));
                            break;
                        case "H":
                            h.Add(Convert.ToInt32(temp[j].Substring(1)));
                            break;
                        case "D":
                            d.Add(Convert.ToInt32(temp[j].Substring(1)));
                            break;
                        case "C":
                            c.Add(Convert.ToInt32(temp[j].Substring(1)));
                            break;
                    }
                }

                //將各花色的牌由大排到小
                s.Sort();
                s.Reverse();
                h.Sort();
                h.Reverse();
                d.Sort();
                d.Reverse();
                c.Sort();
                c.Reverse();

                //把牌放進字串
                foreach (var item in s)
                {
                    oup[i] += "S" + item+" ";
                }

                foreach (var item in h)
                {
                    oup[i] += "H" + item + " ";
                }
                
                foreach (var item in d)
                {
                    oup[i] += "D" + item + " ";
                }

                foreach (var item in c)
                {
                    oup[i] += "C" + item + " ";
                }
                //修剪空白字元
                oup[i] = oup[i].Trim();

                //清空牌的序列 給下一次用
                s.Clear();
                h.Clear();
                d.Clear();
                c.Clear();
            }

            //輸出重組好的字串
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(oup[i]);
            }
        }
    }
}
