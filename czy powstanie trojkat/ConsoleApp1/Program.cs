using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj bok A: ");
            double bok_a = double.Parse(Console.ReadLine());
            Console.Write("Podaj bok B: ");
            double bok_b = double.Parse(Console.ReadLine());
            Console.Write("Podaj bok C: ");
            double bok_c = double.Parse(Console.ReadLine());
            if ((bok_a + bok_b > bok_c) && (bok_a + bok_c > bok_b) && (bok_b + bok_c > bok_a)) Console.WriteLine("\nZ podanych bokow mozna zbudowac trojkat.");
            else Console.WriteLine("\nZ podanych bokow nie mozna zbudowac trojkata.");
        }
    }
}
