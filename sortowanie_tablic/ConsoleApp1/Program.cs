using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = new int[10];
            GenerowanieLiczb(tablica);
            WyswietlTablice(tablica);
            SortowaniePrzezWybieranie(tablica);//nie dziala :(
            SortowaniePrzezWstawianie(tablica);
            Console.WriteLine("PO ZMIANIE PRZEZ WSTAWIANIE");
            WyswietlTablice(tablica);
        }
        static void GenerowanieLiczb(int[] tablica)
        {
            Random generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                tablica[i] = generator.Next(1, 11);
            }
        }
        static void WyswietlTablice(int[] tablica)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(tablica[i]);
            }
        }
        static void SortowaniePrzezWstawianie(int[] tablica)
        {
            for (int i = 0; i < 10; i++)
            {
                int x;//przechowywuje najmniejsza
                int y;//indeks najmniejszej
                int z;//do zamiany
                for (int j = 0; j < 9; j++)
                {
                    x = tablica[j];
                    if (x > tablica[j + 1])
                    {
                        x = tablica[j + 1];
                        y = j + 1;
                    }
                    else continue;
                    //zamiana
                    z = tablica[j];
                    tablica[j] = x;
                    tablica[y] = z;
                }
            }
        }
        static void SortowaniePrzezWybieranie(int[] tablica)
        {

            int[] tab = new int[10];
            tab[0] = tablica[0];
            for (int i = 1; i < 10; i++)
            {
                int x = tablica[i];
                if (tab[i - 1] <= x)
                {
                    tab[i] = x;
                    continue;
                }
                else
                {
                    for (int j = i; j <= 0; j--)
                    {
                        tab[j] = tab[j - 1];
                        if (x <= tab[j])
                        {
                            tab[j - 1] = x;
                            continue;
                        }
                    }
                }
            }
            Console.WriteLine("PO ZMIANIE PRZEZ WYBIERANIE");
            for (int i = 0; i < 10; i++) Console.WriteLine(tab[i]);

        }
    }
}
