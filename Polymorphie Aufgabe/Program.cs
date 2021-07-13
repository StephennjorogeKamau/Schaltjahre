using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie_Aufgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Erstellen Sie eine Konsolenanwendung unter Verwendung von Polymorphie.
           Basis Klasse mit 2 Kinder Klassen als Ausgangspunkt.
           Sie erstellen eine kleine Software die es erlaubt Kunden und Mitarbeiter zu verwalten.
           Sowohl die Kunden als auch die Mitarbeiter sollen einen Geburtstag haben.
           Die Mitarbeiter sollen zusätlich ein Gehalt haben.
           Die Kunden sollen zusätzlich ein Lieblingsprodukt.
           Erstellen Sie in der Main Methode zumindest 2 Kunden und 2 Mitarbeiter in der selben Sammlung als Testdaten.
           Lassen Sie in der Main Methode eine Schleife laufen die für diese Sammlung alle Geburtstage gegen 
           ein bestimtes Datum überprüft.
           // Beispiel
               DateTime pruefDatum = new DateTime(...);
               for .....
               1. Wenn das Datum dem Geburtsdatum entspricht soll eine gemeinsame Methode ausgeführt werden.
               2. Wenn das Datum im Dezember liegt soll NUR den Mitarbeitern eine Bonuszahlung als Methode ausgeführt werden.*/


            Kunden kunde1 = new Kunden();
            Kunden kunde2 = new Kunden();
            

            Console.WriteLine("Kunden GeburtsDatum Bitte: ");
            DateTime.TryParse(Console.ReadLine(), out DateTime kundeDatum);







            Console.ReadKey();
        }
    }
}
