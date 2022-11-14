using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Figury
    {
        public List<double> Prostokat(double a, double b)
        {
            List<double> prostokat = new List<double>();
            prostokat.Add(a * b);
            prostokat.Add(a + a + b + b);
            return prostokat;
        }
        public List<double> Okrag(double r)
        {
            List<double> okrag = new List<double>();
            okrag.Add(3.14*r*r);
            okrag.Add(2*3.14*r);
            return okrag;
        }
        public List<double> Trojkat(double a, double h)
        {
            List<double> trojkat = new List<double>();
            trojkat.Add(a * h / 2);
            trojkat.Add(3 * a);
            return trojkat;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Figury figura1 = new Figury();
            List<double> lp = figura1.Prostokat(6, 9);
            List<double> lo = figura1.Okrag(7);
            List<double> lt = figura1.Trojkat(5, 8);
            Console.WriteLine("Pole prostokąta: " + lp[0] + "\nObwód prostokąta: " + lp[1]);
            Console.WriteLine("\nPole okręgu: " + lo[0] + "\nObwód okręgu: " + lo[1]);
            Console.WriteLine("\nPole trójkąta: " + lt[0] + "\nObwód trójkąta: " + lt[1]);
        }
    }
}
