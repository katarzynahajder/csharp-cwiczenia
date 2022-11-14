using System;

namespace ConsoleApp1
{
    class Zamiana
    {
        private string liczba_b;
        private string liczba_s;
        public string zamiana_na_binarna(double podana_liczba)
        {
            for (; ; )
            {
                if (podana_liczba == 0) break;
                else
                {
                    if (podana_liczba % 2 == 0)
                    {
                        liczba_b = "0" + liczba_b;
                        podana_liczba *= 0.5;
                    }
                    else
                    {
                        liczba_b = "1" + liczba_b;
                        podana_liczba -= 1;
                        podana_liczba *= 0.5;
                    }
                }
            }
            return (liczba_b);
        }
        public string zamiana_na_szesnastkowa(double podana_liczba)
        {
            for (; ; )
            {
                if (podana_liczba == 0) break;
                else
                {
                    for (; ; )
                    {
                        if (podana_liczba % 16 >= 10)
                        {
                            switch (podana_liczba % 16)
                            {
                                case 10:
                                    liczba_s = "A" + liczba_s;
                                    break;
                                case 11:
                                    liczba_s = "B" + liczba_s;
                                    break;
                                case 12:
                                    liczba_s = "C" + liczba_s;
                                    break;
                                case 13:
                                    liczba_s = "D" + liczba_s;
                                    break;
                                case 14:
                                    liczba_s = "E" + liczba_s;
                                    break;
                                case 15:
                                    liczba_s = "F" + liczba_s;
                                    break;
                            }
                            podana_liczba -= podana_liczba % 16;
                            podana_liczba /= 16;
                        }
                        else if (podana_liczba % 16 <= 10) break;
                    }
                    if (podana_liczba == 0) break;
                    liczba_s = podana_liczba % 16 + liczba_s;
                    podana_liczba -= podana_liczba % 16;
                    podana_liczba /= 16;
                }
            }
            return (liczba_s);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Zamiana liczba1 = new Zamiana();
            Console.Write("Podaj liczbe dziesietna do zamiany: ");
            double liczba = double.Parse(Console.ReadLine());
            Console.WriteLine("Po zamianie na binarna wynosi: " + liczba1.zamiana_na_binarna(liczba));
            Console.WriteLine("Po zamianie na szesnastkowa wynosi: " + liczba1.zamiana_na_szesnastkowa(liczba));
        }
    }
}
