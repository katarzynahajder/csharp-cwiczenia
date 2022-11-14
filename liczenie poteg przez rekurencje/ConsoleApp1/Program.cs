using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static double potegi(double x, double y)
        {
            if (y >= 1) return x * potegi(x, y - 1);
            else return 1;
        }
        static void Main(string[] args)
        {
            int x = 2;
            int y = 8;
            Console.WriteLine(x + " do potęgi " + y + " wynosi : " + potegi(x, y));
        }
    }
}
