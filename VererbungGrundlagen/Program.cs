using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VererbungGrundlagen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Einzelne Klassen (Ohne Verrbung)
            kundenEinzel kundeOhneVerbung = new kundenEinzel();
            Mitarbeiter mitarbeiterOhneVerbung = new Mitarbeiter();

            kundeOhneVerbung.Name = "Kamau";
            Console.WriteLine(mitarbeiterOhneVerbung.Name);

            mitarbeiterOhneVerbung.Name = "Njoroge";
                Console.WriteLine( mitarbeiterOhneVerbung.Name);

            kundeOhneVerbung.Rabbat = 10;
            mitarbeiterOhneVerbung.Gehalt = 4m;

            KundenVererbt kundemitVererbung = new KundenVererbt();
            MitarbeiterVererbt mitarbeitermitVererbung = new MitarbeiterVererbt();

            kundemitVererbung.Name = "Betty";
            kundemitVererbung.Rabbat = 15;

            mitarbeitermitVererbung.Name = "Njosh";
            mitarbeitermitVererbung.Gehalt = 34m;

            Console.ReadLine();
        }

    }
}
