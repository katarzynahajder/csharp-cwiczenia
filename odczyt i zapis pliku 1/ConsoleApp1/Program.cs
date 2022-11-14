using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader odczyt = new StreamReader("odczyt.txt");
            StreamWriter zapis = new StreamWriter("zapis.txt");
            for (int i = 0; i < 12; i++)
            {
                string miasto = odczyt.ReadLine();
                if (miasto.Length <= 6)
                {
                    zapis.WriteLine(miasto);
                }
            }
            odczyt.Close();
            zapis.Close();
        }
    }
}