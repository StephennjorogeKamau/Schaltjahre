using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quittung
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variablen
            int mellone;
            double preis, rabbat5 = 0.95, rabatt10 = 0.99, ergeb;
            bool check;

            //Aktuellepreis
            do
            {
                Console.Write("Bitte geben Sie die aktuelle Preis ein: ");
                check = double.TryParse(Console.ReadLine(), out preis) ;
                if (!check)
                {
                    Console.WriteLine("Bitte nur Zahl eingaben. ");
                }
            } while (!check);
            Console.WriteLine();


            //eingabe Menge
            do
            {
                Console.Write("Bitte geben Sie ein Menge ein: ");
                check = int.TryParse(Console.ReadLine(), out mellone);
                if (!check)
                {
                    Console.WriteLine("Bitte nur Zahl eingaben. ");
                }
            } while (!check);
            Console.WriteLine();

            //rechnung

            if (mellone >= 10)

            {
                ergeb = preis * mellone * rabatt10;
            }
            else if (mellone >= 5)
            {
                ergeb = preis * mellone * rabbat5;
            }
            else
            {
                ergeb = preis * mellone;
            }

            Console.WriteLine();
            Console.WriteLine("Ihre Ergebnise. " + ergeb + "Euro");
            Console.WriteLine();
            Console.WriteLine("Bitte drucken Sie E zu ende an: ");
            Console.ReadKey();
        }
    }
}
