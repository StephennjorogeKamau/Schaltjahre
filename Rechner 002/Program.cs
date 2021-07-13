using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechner_002
{
    class Program
    {
        static void Main(string[] args)
        {

            //Variablen
            string eingabe;
            double zahl1, zahl2, erg;
            bool check;

            while (true)
            {
                //Eingabe Zahl 1
                do
                {
                    Console.Clear();
                    Console.Write("Bitte geben Sie ihre erste Zahl ein: ");
                    eingabe = Console.ReadLine();

                    if (eingabe.ToUpper() == "EXIT")
                        Environment.Exit(0);

                    check = double.TryParse(eingabe, out zahl1);

                    if (!check)
                    {
                        Console.WriteLine("Bitte nur Ziffern eingeben. Weiter mit beliebiger Taste.");
                        Console.ReadKey();
                    }
                } while (!check);

                //Eingabe Zahl 2
                do
                {
                    Console.Clear();
                    Console.Write("Bitte geben Sie ihre zweite Zahl ein: ");
                    eingabe = Console.ReadLine();

                    if (eingabe.ToUpper() == "EXIT")
                        Environment.Exit(0);

                    check = double.TryParse(eingabe, out zahl2);

                    if (!check)
                    {
                        Console.WriteLine("Bitte nur Ziffern eingeben. Weiter mit beliebiger Taste.");
                        Console.ReadKey();
                    }
                } while (!check);

                //Menü
                do
                {
                    check = true;
                    Console.Clear();
                    Console.WriteLine("Wahl der Mathematischen Funktion");
                    Console.WriteLine();
                    Console.WriteLine("Addition:       wählen Sie \"+\"");
                    Console.WriteLine("Subtraktion:    wählen Sie \"-\"");
                    Console.WriteLine("Multiplikation: wählen Sie \"*\"");
                    Console.WriteLine("Division:       wählen Sie \"/\"");
                    Console.WriteLine("Potenzieren:    wählen Sie \"p\"");
                    Console.WriteLine();
                    Console.Write("Wählen Sie die Rechenart: ");
                    eingabe = Console.ReadLine();

                    if (eingabe.ToUpper() == "EXIT")
                        Environment.Exit(0);

                    //switch & Ausgabe
                    switch (eingabe)
                    {
                        case "+":
                            Addition(zahl1, zahl2);

                            break;
                        case "-":
                            Subtraction(zahl1, zahl2);
                            break;

                        case "*":
                            Multiplication(zahl1, zahl2);
                            break;
                        case "/":
                            if (zahl2 == 0)
                                Console.WriteLine("Eine Division durch 0 ist nicht möglich.");
                            else
                                Division(zahl1, zahl2);
                            break;
                        case "p":
                            erg = Math.Pow(zahl1, zahl2);
                            Console.WriteLine("Das Ergebnis der Potenzierung der Zahlen " + zahl1 + " und " + zahl2 +
                             " ergibt ein Ergebnis von " + erg);
                            break;
                        default:
                            Console.WriteLine("Bitte nur ein Rechenzeichen angeben.");
                            check = false;
                            break;
                    }
                    Console.WriteLine("Weiter mit beliebiger Taste...");
                    Console.WriteLine();
                    Console.WriteLine("Exit zu Ende");
                    Console.ReadKey();
                } while (!check);

            }
        }
        static void Addition(double zal1, double zahl2)
        {
            double Ergebnis = zal1 + zahl2;
            Console.WriteLine("Ergebnis: " + Ergebnis);
        }
        static void Subtraction(double zal1, double zahl2)
        {
            double Ergebnis = zal1 - zahl2;
            Console.WriteLine("Ergebnis: " + Ergebnis);
        }
        static void Multiplication(double zal1, double zahl2)
        {
            double Ergebnis = zal1 * zahl2;
            Console.WriteLine("Ergebnis: " + Ergebnis);
        }
        static void Division(double zal1, double zahl2)
        {
            double Ergebnis = zal1 / zahl2;
            Console.WriteLine("Ergebnis: " + Ergebnis);
        }
    } 
}
