using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            string x = Console.ReadLine();

            switch (x)
            {
                case "3":
                case "4":
                case "5":
                    Console.WriteLine("Spring");
                    break;
                case "6":
                case "7":
                case "8":
                    Console.WriteLine("Summer");
                    break;
                case "9":
                case "10":
                case "11":
                    Console.WriteLine("Autumn");
                    break;
                case "12":
                case "1":
                case "2":
                    Console.WriteLine("Winter");
                    break;
            }
        }
    }
}
