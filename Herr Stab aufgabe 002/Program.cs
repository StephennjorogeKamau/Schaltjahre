using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herr_Stab_aufgabe_002
{
    class Program
    {
        static void Main(string[] args)
        {
            RAM ram = new RAM();
            ram.Bezeichnen = "Vegence";
            ram.Nettopreis = 120m;
            ram.Bestant = 100000;
            ram.Kapazität = 16;
            ram.Taktung = 3200;

            Netzteil netzteil = new Netzteil();
            netzteil.Bezeichnen = "1200i";
            netzteil.Bestant = 0;
            netzteil.leistung = 1200;
            netzteil.klasse = "Platinum";

            Gehäuse gehaeuse = new Gehäuse();
            gehaeuse.Bezeichnen = "1000d";
            gehaeuse.Nettopreis = 600m;
            gehaeuse.Bestant = 50;
            gehaeuse.Formfaktor = "EATX";
            gehaeuse.Farbe = "Schwaz";
            Console.WriteLine($"Bezeichen:{ram.Bezeichnen}  Nettopreis:{ ram.Nettopreis}  Bestand:{ram.Bestant}  Kapazität:{ram.Kapazität} Taktung:{ram.Taktung}\n" +
                $"Bezeichnen: {netzteil.Bezeichnen} Bestand:{netzteil.Bestant} Leistung:{netzteil.leistung} Klasse:{netzteil.klasse}\n" +
              $"Bezeichnen:{gehaeuse.Bezeichnen} Nettopreis:{gehaeuse.Nettopreis} Bestand:{gehaeuse.Bestant} Formfaktor:{gehaeuse.Formfaktor} Farbe:{gehaeuse.Farbe}");

            //Brutto rechnen
            Console.WriteLine(ram.Brutto());
            Console.WriteLine(netzteil.Brutto());
            Console.WriteLine(gehaeuse.Brutto());

            RAM kit2 = new RAM();
            kit2.Bezeichnen = "2x8GB kit";
            kit2.Nettopreis = 160;

            RAM kit4 = new RAM();
            kit4.Bezeichnen = "4x8GB kit";
            kit4.Nettopreis = 320;

            Console.WriteLine(kit4.BruttoMitRabatt(4));
            Console.WriteLine(kit2.BruttoMitRabatt(2));


            Console.ReadKey();
        }
    }
}
