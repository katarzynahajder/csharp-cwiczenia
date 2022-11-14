using System;

namespace ConsoleApp1
{
    class Osoba
    {
        string imie;
        string nazwisko;
        public void set_imie(string par)
        {
            imie = par;
        }
        public string get_imie()
        {
            return (imie);
        }
        public void set_nazwisko(string par)
        {
            nazwisko = par;
        }
        public string get_nazwisko()
        {
            return (nazwisko);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba1 = new Osoba();
            osoba1.set_imie("Jan");
            osoba1.set_nazwisko("Kowalski");
            Console.WriteLine("Imie: "+osoba1.get_imie());
            Console.WriteLine("Nazwisko: "+osoba1.get_nazwisko());
        }
    }
}
