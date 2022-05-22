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
            /* 
             * Górne komendy są automatyczne od programu
             * Console.WriteLine pisze tekst na całej linijce, tekst wpisuje się pod linijką
             */
            Console.WriteLine("Wpisz tekst do zaszyfrowania szyfrem Cezara:");
            // foreach to pętla, która służy do odczytywania elementów kolekcji 
                foreach (var i in Console.ReadLine())
            {
                // Konwertuje wartość na liczbę w Unicode, poprzez proste obliczenia wyznacza nam nowy alfabet
                Console.Write(Convert.ToChar((i - 'a' + 4) + 'a'));
            }
                // Powoduje, że program nie kończy działania od razu, nie jest to rzecz potrzebna 
            Console.ReadKey(true);
        }
    }
}