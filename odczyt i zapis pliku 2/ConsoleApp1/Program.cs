using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] miasta = File.ReadAllLines("odczyt.txt");
            using StreamWriter zapis = new StreamWriter("zapis.txt");
            foreach (string miasto in miasta)
            {
                if (miasto.Length <= 6) 
                {
                    zapis.WriteLineAsync(miasto);
                }
            }
            zapis.Close();
        }
    }
}