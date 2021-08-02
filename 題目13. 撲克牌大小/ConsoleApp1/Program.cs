//using System;
//using System.Collections.Generic;

//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main()
//        {
//            //輸入有幾行
//            int x = Convert.ToInt32(Console.ReadLine());
//            string[] oup = new string[x];

//            //花色的牌
//            List<int> s = new List<int>();
//            List<int> d = new List<int>();
//            List<int> h = new List<int>();
//            List<int> c = new List<int>();

//            //重組輸入的字串
//            for (int i = 0; i < x; i++)
//            {
//                oup[i] = Console.ReadLine();
//                string[] temp = oup[i].Split(' ');
//                oup[i] = "";

//                //把暫存陣列的撲克牌存進各自的花色
//                for (int j = 0; j < temp.Length; j++)
//                {   
//                    switch(temp[j].Substring(0, 1))
//                    {
//                        case "S":
//                            s.Add(Convert.ToInt32(temp[j].Substring(1)));
//                            break;
//                        case "H":
//                            h.Add(Convert.ToInt32(temp[j].Substring(1)));
//                            break;
//                        case "D":
//                            d.Add(Convert.ToInt32(temp[j].Substring(1)));
//                            break;
//                        case "C":
//                            c.Add(Convert.ToInt32(temp[j].Substring(1)));
//                            break;
//                    }
//                }

//                //將各花色的牌由大排到小
//                s.Sort();
//                s.Reverse();
//                h.Sort();
//                h.Reverse();
//                d.Sort();
//                d.Reverse();
//                c.Sort();
//                c.Reverse();

//                //把牌放進字串
//                foreach (var item in s)
//                {
//                    oup[i] += "S" + item+" ";
//                }

//                foreach (var item in h)
//                {
//                    oup[i] += "H" + item + " ";
//                }

//                foreach (var item in d)
//                {
//                    oup[i] += "D" + item + " ";
//                }

//                foreach (var item in c)
//                {
//                    oup[i] += "C" + item + " ";
//                }
//                //修剪空白字元
//                oup[i] = oup[i].Trim();

//                //清空牌的序列 給下一次用
//                s.Clear();
//                h.Clear();
//                d.Clear();
//                c.Clear();
//            }

//            //輸出重組好的字串
//            for (int i = 0; i < x; i++)
//            {
//                Console.WriteLine(oup[i]);
//            }
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prc
{
    class Program
    {

        static void Main(string[] args)
        {

            string tempString;
            // 疊層
            int lineNumber;
            // 撲克牌
            char[] Color = { 'S', 'H', 'D', 'C' };
            // 互換
            void change(ref string a, ref string b)
            {
                string temp;
                temp = a;
                a = b;
                b = temp;
            }
            // 轉數字
            int turnNumber(string a)
            {
                int b;
                if (a.Length < 3)
                {
                    b = Convert.ToInt32(a.Substring(1, 1));
                }
                else
                {
                    b = Convert.ToInt32(a.Substring(1, 2));
                }
                return b;
            }
            // 比對陣列 回傳index
            int checkColor(char a)
            {
                for (int j = 0; j < Color.Length; j++)
                {
                    if (Color[j] == a)
                        return j;
                }
                return 0;
            }
            // 排序花色 (交換排序)
            string[] sort(string[] arr)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    // 取花色比大小
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        // 若花色輸了 => 互換
                        if (checkColor(Convert.ToChar(arr[j].Substring(0, 1))) > checkColor(Convert.ToChar(arr[k].Substring(0, 1))))
                        {
                            change(ref arr[j], ref arr[k]);
                        }

                        // 若花色相同，比數字
                        else if (checkColor(Convert.ToChar(arr[j].Substring(0, 1))) == checkColor(Convert.ToChar(arr[k].Substring(0, 1))))
                        {
                            if (turnNumber(arr[j]) < turnNumber(arr[k]))
                            {
                                change(ref arr[j], ref arr[k]);
                            }
                        }
                    }
                }

                return arr;
            }
            //-----------多餘-----------
            // 初始化撲克牌陣列
            string[,] Cards = new string[4, 13];

            for (int i = 0; i < Cards.GetLength(0); i++)
            {
                for (int j = 0; j < Cards.GetLength(Cards.Rank - 1); j++)
                {
                    //Console.WriteLine($"{Color[i]}{j + 1}");
                    Cards[i, j] = $"{Color[i]}{j + 1}";
                }
            }
            //-----------多餘-----------
            string[,] tempArr;
            int tempInt;
            char tempChar;
            // 使用者輸入
            lineNumber = Convert.ToInt32(Console.ReadLine());
            // 資料存入二維陣列 並 排序
            string[][] lineValue = new string[lineNumber][];
            for (int i = 0; i < lineNumber; i++)
            {
                // 使用者輸入的 牌 資料
                tempString = Console.ReadLine();
                // 疊層牌數
                tempInt = tempString.Split(' ').Length;
                // 資料切割後，存入lineValue
                lineValue[i] = new string[tempInt];
                lineValue[i] = sort(tempString.Split(' '));
            }
            foreach (var item in lineValue)
            {
                foreach (var item2 in item)
                {
                    Console.Write($"{item2} ");
                }
                Console.WriteLine();
            }
        }
    }
}
