using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter("plik.txt"))
            {
                for (int i = 0; i < 20; i++) sw.WriteLine(i);
            }
            using (StreamReader sr = new StreamReader("plik.txt"))
            {
                for (int i = 0; i < 20; i++) Console.Write(sr.ReadLine() + " ");
            }
        }
    }
}
