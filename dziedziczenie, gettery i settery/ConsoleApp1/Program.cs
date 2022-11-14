using System;

namespace ConsoleApp1
{
    class Trapez
    {
        double bok_a;
        double bok_b;
        double wysokosc;
        public double Bok_a
        {
            get { return bok_a; }
            set { bok_a = value; }
        }
        public double Bok_b
        {
            get { return bok_b; }
            set { bok_b = value; }
        }
        public double Wysokosc
        {
            get { return wysokosc; }
            set { wysokosc = value; }
        }
        public void Oblicz_pole_trapezu(double a, double b, double h)
        {
            Console.WriteLine("Pole trapezu: " + 0.5 * (a + b) * h);
        }
    }
    class Prostokat : Trapez
    {
        public void Oblicz_pole_prostokata(double a, double b)
        {
            Console.WriteLine("Pole prostokata: " + a * b);
        }
    }
    class Prostopadloscian : Trapez
    {
        public void Oblicz_pole_figury(double a, double b, double c)
        {
            Console.WriteLine("Pole prostopadłościanu: " + 2 * (a * b + a * c + b * c));
        }
        public void Oblicz_objetosc_figury(double a, double b, double c)
        {
            Console.WriteLine("Objętość prostopadłościanu: " + a * b * c);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Trapez trapez1 = new Trapez();
            trapez1.Bok_a = 4;
            trapez1.Bok_b = 7;
            trapez1.Wysokosc = 5;
            trapez1.Oblicz_pole_trapezu(trapez1.Bok_a, trapez1.Bok_b, trapez1.Wysokosc);

            Prostokat prostokat1 = new Prostokat();
            prostokat1.Bok_a = 6;
            prostokat1.Bok_b = 12;
            prostokat1.Oblicz_pole_prostokata(prostokat1.Bok_a, prostokat1.Bok_b);

            Prostopadloscian figura1 = new Prostopadloscian();
            figura1.Bok_a = 6;
            figura1.Bok_b = 12;
            figura1.Wysokosc = 5;
            figura1.Oblicz_pole_figury(figura1.Bok_a, figura1.Bok_b, figura1.Wysokosc);
            figura1.Oblicz_objetosc_figury(figura1.Bok_a, figura1.Bok_b, figura1.Wysokosc);
        }
    }
}