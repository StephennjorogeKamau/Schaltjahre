using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnervetwaltung
{
    static class DasMenu
    {
        public static void Neuepc(ITVerwaltung it)
        {
            it.RechnerHinzufügen(new Grafische("Back Office", "125.147.124.54", 2.4f, 4, 250, 27.80f, "GTX-45-Intern"));
            it.RechnerHinzufügen(new Beuro("128.162.172.15", "Sekritär", 2.5f, 8, 500));
            it.RechnerHinzufügen(new Server("Backup-Center", "24.24.25.32", 2.5f, 4, 16, 1000, 5, "Backup", 4));
            //it.RechnerHinzufügen(new Terminal("125.125.125.15", "HTTP Terminal", "Karlsruhe", );
        }
        public static void Menus(ITVerwaltung it)
        {
            Console.Clear();
            Console.WriteLine("Bitte wählen Sie Ihre Optionen ein");
            Console.WriteLine("1. Aller Rechner Anzeigen");
            Console.WriteLine("2. Bestimmten Rechnertyps mit allen Daten Anzeige");
            Console.WriteLine("3. Anzahl der gespeicherten Rechner Anzeigen");
            Console.WriteLine("4. Hinzufügen eines Rechners");
            Console.WriteLine("5. Löschen eines Rechners");
            Console.WriteLine("6. Programmende");
            Console.WriteLine();

            int Userinput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();


            switch (Userinput)
            {

                case 1:
                    it.RechnerZähler();
                    break;
                case 2:
                    BestimmteRechnertyps(it);
                    break;
                case 3:

                    break;
                case 4:
                    

                    break;
                case 5:
                    break;
                case 6:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Bitte nur 1-6 wählen");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("Weiter mit beliebiger Taste...");
            Console.ReadKey();
        }
        //2. Bestimmten Rechnertyps mit allen Daten Anzeige
        public static void BestimmteRechnertyps(ITVerwaltung it)
        {
            Console.Clear();
            Console.WriteLine("(1) Alle Büro-Workstations anzeigen");
            Console.WriteLine("(2) Alle Grafischen Wokstations anzeigen");
            Console.WriteLine("(3) Alle Server anzeigen");
            Console.WriteLine("(4) Alle Terminals anzeigen");
            Console.WriteLine("(5) Zurück");
            Console.WriteLine();
            Console.Write("Ihre Auswahl: ");
            int userinput = Convert.ToInt32(Console.ReadLine());
            switch (userinput)
            {
                case 1:
                    foreach (Rechner item in it.computersList)
                    {
                        if ((item is Beuro) && !(item is Grafische))
                        {
                            Console.WriteLine();
                            Console.WriteLine(item);
                            Console.WriteLine();
                        }
                    }
                break;
                case 2:
                    foreach (Rechner item in it.computersList)
                    {
                        if (item is Grafische) /*&& !(item is Grafische))*/
                        {
                            Console.WriteLine();
                            Console.WriteLine(item);
                            Console.WriteLine();
                        }
                    }
                    break;
                case 3:
                    foreach (Rechner item in it.computersList)
                    {
                        if (item is Server) /*&& !(item is Grafische))*/
                        {
                            Console.WriteLine();
                            Console.WriteLine(item);
                            Console.WriteLine();
                        }
                    }
                    break;
                case 4:
                    foreach (Rechner item in it.computersList)
                    {
                        if (item is Terminal) /*&& !(item is Grafische))*/
                        {
                            Console.WriteLine();
                            Console.WriteLine(item);
                            Console.WriteLine();
                        }
                    }
                    break;
                case 5:
                    bool check = false;
                    if (check == true)
                    {
                        Console.WriteLine("Beliebiger Taste drucken");
                    }
                    break;

                default:
                    Console.WriteLine("Fehler eingabe");
                    break;
            }
        }
        //3. Anzahl der gespeicherten Rechner Anzeigen"
        public static void AnzahlderRechner()
        {

        }

    }
}
