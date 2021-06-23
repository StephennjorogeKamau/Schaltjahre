using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overrideBeispeil
{
    class Program
    {
        static void Main(string[] args)
        {
            FilmE filmE = new FilmE("The Lion King", 10);
            Film13 film13 = new Film13("Zuruck in dei Zukunft", 5);
            Film16 film16 = new Film16("Predetor", 15);
            Film18 film18 = new Film18("Deadpool", 8);


            Console.WriteLine($"{filmE.Titel}: {filmE.Bestand} Stuck");
            Console.WriteLine($"{film13.Titel}: {film13.Bestand} Stuck");
            Console.WriteLine($"{film16.Titel}: {film16.Bestand} Stuck");
            Console.WriteLine($"{film18.Titel}: {film18.Bestand} Stuck");

            filmE.Aufstocken(5);
            film13.Aufstocken(5);
            film16.Aufstocken(5);
            film18.Aufstocken(5);

            Console.WriteLine();
            Console.WriteLine($"{filmE.Titel}: {filmE.Bestand} Stuck");
            Console.WriteLine($"{film13.Titel}: {film13.Bestand} Stuck");
            Console.WriteLine($"{film16.Titel}: {film16.Bestand} Stuck");
            Console.WriteLine($"{film18.Titel}: {film18.Bestand} Stuck");

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine();
            Console.WriteLine($"{filmE.Titel}: {filmE. PreisBerechnen(10):C2}");
            Console.WriteLine($"{film13.Titel}: {film13.PreisBerechnen(10):C2}");
            Console.WriteLine($"{film16.Titel}: {film16.PreisBerechnen(10):C2}");
            Console.WriteLine($"{film18.Titel}: {film18.PreisBerechnen(10):C2}");

            Console.WriteLine();
            Console.WriteLine("Darf es ein 15 jariger Kunde ausleihen?");
            Console.WriteLine($"{filmE.Titel}: {filmE.DarfVerliehenWerden(15)}");
            Console.WriteLine($"{film13.Titel}: {film13.DarfVerliehenWerden(15)}");
            Console.WriteLine($"{film16.Titel}: {film16.DarfVerliehenWerden(15)}");
            Console.WriteLine($"{film18.Titel}: {film18.DarfVerliehenWerden(15)}");

            Console.WriteLine();
            Console.WriteLine("Darf es ein 16 jariger Kunde ausleihen?");
            Console.WriteLine($"{filmE.Titel}: {filmE.DarfVerliehenWerden(16)}");
            Console.WriteLine($"{film13.Titel}: {film13.DarfVerliehenWerden(16)}");
            Console.WriteLine($"{film16.Titel}: {film16.DarfVerliehenWerden(16)}");
            Console.WriteLine($"{film18.Titel}: {film18.DarfVerliehenWerden(16)}");
            Console.WriteLine();
            Console.WriteLine("Darf es ein 18 jariger Kunde ausleihen?");
            Console.WriteLine($"{filmE.Titel}: {filmE.DarfVerliehenWerden(18)}");
            Console.WriteLine($"{film13.Titel}: {film13.DarfVerliehenWerden(18)}");
            Console.WriteLine($"{film16.Titel}: {film16.DarfVerliehenWerden(18)}");
            Console.WriteLine($"{film18.Titel}: {film18.DarfVerliehenWerden(18)}");


            Console.ReadKey();
        }
    }
}
