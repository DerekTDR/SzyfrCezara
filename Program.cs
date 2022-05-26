using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SzyfrCezara
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] abc = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            // Alfabet "abc"
            Console.WriteLine("Podaj zdanie do zaszyfrowania");
            string wejscie = Console.ReadLine();
            //Objekt "wejscie" o wartości jaka zostanie odczytana typu string
            char[] zdn = wejscie.ToCharArray();
            Console.Write("O ile chcesz przesunąć? ");
            int mv;
            // Objekt "mv" służący do przesuwania alfabetu
            Int32.TryParse(Console.ReadLine(), out mv);
            char[] szyfr = new char[zdn.Length];
            //
            // START FOR
            for (int i = 0; i < zdn.Length; i++)
            {
                if (zdn[i] == ' ' | zdn[i] == '\n') continue;
                // Niech sprawdza lewą i prawą stronę, \n = nowa linia
                int pos = Array.IndexOf(abc, zdn[i]);
                int newPos = (pos + mv) % 26;
                // Dodawanie, a potem reszta z dzielenia
                szyfr[i] = abc[newPos];
            }
            // END FOR
            string wyjscie = string.Join("", szyfr);
            Console.Write(wyjscie);
            // Wynik działań
            Console.ReadKey(true);
            // Niech czyta klawisz, by nie kończył działania jeszcze
        }
    }
}