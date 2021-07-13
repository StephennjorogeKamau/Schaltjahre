using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_Herr_Stab
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Erstellen Sie eine Konsolenanwendung.
            Definieren Sie ein Array von Dezimalzahlen(Zuffalsgenerator).
            Geben Sie diese Zahlen in einer Tabelle mit 2 Spalten wieder aus:
             Spalte: Den original Wert
             Spalte: Wert * 1,19
            Formatieren und Positionieren Sie die ausgabe wie im Beispiel
               */

            //Variablen 
            Console.OutputEncoding = Encoding.UTF8;

            Random rng = new Random();

            decimal[] preise = new decimal[20];

            for (int i = 0; i < preise.Length; i++)
            {
                preise[i] = Convert.ToDecimal(rng.NextDouble() * 10000 + 123);
            }

            Console.WriteLine($"{"Netto", -12} | {"Brutto",-12}");
            Console.WriteLine("─────────────┼────────────────");
            for (int i = 0; i <preise.Length; i++)
            {
                Console.WriteLine($"{preise[i],12:C2} | {preise[i] * 1.19m,12:C2}");
            }

            Console.ReadKey();
        }
    }
}
