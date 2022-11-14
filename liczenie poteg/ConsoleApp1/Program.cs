using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj podstawe: ");
            double podstawa = double.Parse(Console.ReadLine());
            Console.Write("Podaj wykladnik: ");
            double wykladnik = double.Parse(Console.ReadLine());
            double wynik = 1;
            if (wykladnik < 0)
            {
                podstawa = 1 / podstawa;
                wykladnik *= (-1);
                for (int i = 0; i < wykladnik; i++)
                {
                    wynik *= podstawa;
                }
            }
            else
            {
                for (int i = 0; i < wykladnik; i++)
                {
                    wynik *= podstawa;
                }
            }
            Console.WriteLine("\nWynik wynosi: " + wynik);
        }
    }
}
