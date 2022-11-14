using System;

namespace ConsoleApp1
{
    class Rownania_kwadratowe
    {
        double a;
        double b;
        double c;
        public Rownania_kwadratowe(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double Delta()
        {
            return b * b - 4 * a * c;
        }
        public double X1()
        {
            return (-b - Math.Sqrt(Delta())) / (2 * a);
        }
        public double X2()
        {
            return (-b + Math.Sqrt(Delta())) / (2 * a);
        }
        public int Ilosc_rozwiazan()
        {
            if (Delta() < 0) return 0;
            else if (Delta() > 0) return 2;
            else return 1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rownania_kwadratowe rownanie1 = new Rownania_kwadratowe(1.25, 1, -51);
            Console.WriteLine("Delta podanego równania wynosi: " + rownanie1.Delta());
            Console.WriteLine("Ilość rozwiązań: " + rownanie1.Ilosc_rozwiazan());
            if (rownanie1.Ilosc_rozwiazan() == 2)
            {
                Console.WriteLine("X1=" + rownanie1.X1());
                Console.WriteLine("X2=" + rownanie1.X2());
            }
            else if (rownanie1.Ilosc_rozwiazan() == 1) Console.WriteLine("X=" + rownanie1.X1());
        }
    }
}
