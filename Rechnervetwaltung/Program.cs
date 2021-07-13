using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnervetwaltung
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Neue Rechner erstellen
            //Rechner r1 = new Rechner("Dell", "192.128.172.2");
            //Console.WriteLine("--------------------------------");

            ////Array
            ////Rechner r1 = new Rechner();
            ////Console.WriteLine(r1);

            ////Beuro 
            //Beuro b1 = new Beuro("192.168.172.2", "Sekretariat", 2.4f, 500, 8);
            //Beuro b2 = new Beuro("192.168.172.3", "Buchhaltung", 8.2f, 1000, 16);
            //Beuro b3 = new Beuro("192.168.172.4", "CEO", 8.2f, 500, 8);


            ////Grafische Arbeitsplätze
            //Grafische g1 = new Grafische("Acer", "192.168.172.5", 2.4f, 8, 1000, 23.7f, "Aspire 5 A515 - 55");
            //Grafische g2 = new Grafische("HP", "192.168.172.6", 2.2f, 4, 256, 23.8f, "Iris Plus Graphics G7 (Ice Lake 64 EU)");

            ////Server
            //Server s1 = new Server("Dell T340", "192.168.172.5", 2224.3f, 8, 16, 960, 3, "Back-up", 71) ;
            //Server s2 = new Server("Dell T140", "192.168.172.6", 2334.3f, 4, 32, 500, 5, "Datei Speichern", 52);
            //Server s3 = new Server("Dell T440", "192.168.172.7", 2111.3f, 8, 16, 950, 3, "Buch Haltung", 50);
            //Server s4 = new Server("Dell T300", "192.168.172.8", 2224.3f, 2, 8, 250, 2, "E-Mail", 12);

            //////Alle Rechner erhalten.
            ////ITVerwaltung rechner1 = new ITVerwaltung(); 
            ////rechner1 =

            ////rechners = new Rechner[5];


            //ITVerwaltung Office = new ITVerwaltung();
            //Office.computersList.Add(b1);
            //Office.computersList.Add(b2);
            //Office.computersList.Add(g1);
            //Office.computersList.Add(g2);
            //Office.computersList.Add(s1);
            //Office.computersList.Add(s2);
            //Office.computersList.Add(s3);
            //Office.computersList.Add(s4);


            ////Office.RechnerHinzufügen(b1);
            ////Office.RechnerHinzufügen(b2);
            ////Office.RechnerHinzufügen(g1);
            ////Office.RechnerHinzufügen(g2);
            ////Office.RechnerHinzufügen(s1);
            ////Office.RechnerHinzufügen(s2);
            ////Office.RechnerHinzufügen(s3);
            ////Office.RechnerHinzufügen(s4);




            ////user input
            ////Console.WriteLine("Bitte wählen Sie Ihre Optionen ein");
            ////Console.WriteLine("1. aller Rechner mit allen Daten Anzeigen");
            ////Console.WriteLine("2. aller Rechner eines bestimmten Rechnertyps mit allen Daten Anzeige");
            ////Console.WriteLine("3. Anzahl der gespeicherten Rechner Anzeigen");
            ////Console.WriteLine("4. Hinzufügen eines beliebigen Rechners");
            ////Console.WriteLine("5. Löschen eines beliebigen Rechners");
            ////Console.WriteLine("6. Programmende");
            ////Console.WriteLine();

            ////int Userinput = Convert.ToInt32(Console.ReadLine());
            ////Console.WriteLine();


            ////switch (Userinput)
            ////{
            ////    case 1:
            ////        Console.WriteLine("Sie haben 1 gewählt");
            ////        Console.WriteLine(Office);

            ////        break;
            ////    case 2:
            ////        break;
            ////    case 3:
            ////        break;
            ////    case 4:
            ////        break;
            ////    case 5:
            ////        break;
            ////    case 6:
            ////        break;

            ////    default:
            ////        break;
            ////}

            //Console.ReadLine();

            ITVerwaltung it = new ITVerwaltung();
            DasMenu.Neuepc(it);
            DasMenu.Menus(it);
        }
        
        
        
    }
}
