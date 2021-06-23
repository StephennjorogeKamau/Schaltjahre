using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statischesmember
{
    class Produckts
    {
        public static int NachsteIDNummer = 100; // Dieses statisches Feld wird bearbeitet mit dem Startwert 1.

        public const double USt = 0.19; // eine "constant" ist eine statisches feld, das aber im Quellcode nie verändert werden darf.

        public int ID; // Nicht statiches und jeder instanz einzelt seine ID speichert 
        public string Bezeichnung;
        public double Preis;

        public Produckts (string bezichnung, double preis)
        {
            Bezeichnung = bezichnung;
            Preis = preis;
            ID = NachsteIDNummer;
            NachsteIDNummer++;
        }

    }
}
