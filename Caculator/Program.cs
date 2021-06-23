using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //variablen
            double zahla, zahlb;
            bool check;
            string auswahl;

            //Eingabe 1
            do
            {
                Console.Write(" Bitte geben Sie Erste Zahl ein: ");
                check = double.TryParse(Console.ReadLine(), out zahla);
                if (!check)
                {
                    Console.WriteLine("Bitte nur Zahl eingeben. ");
                }
            } while (!check);

            //Eingabe 2
            do
            {
                Console.Write(" Bitte geben Sie Zweite Zahl ein: ");
                check = double.TryParse(Console.ReadLine(), out zahlb);
                if (!check)
                {
                    Console.WriteLine("Bitte nur Zahl eingeben. ");
                }
            } while (!check);

            //Menu
            Console.WriteLine();
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("exit");
            Console.WriteLine();
            Console.WriteLine("Wählen Sie Ihre Option. ");

            //Augabe
            auswahl = Console.ReadLine();
            switch (auswahl)
            {
                case "1":
                    Console.WriteLine(zahla + "+" + zahlb + " = " +  (zahla + zahlb));
                    break;
                case "2":
                    Console.WriteLine(zahla + "-" + zahlb + " = " + (zahla - zahlb));
                    break;
                case "3":
                    Console.WriteLine(zahla + "*" + zahlb + " = " + (zahla * zahlb));
                    break;
                case "4":
                    Console.WriteLine(zahla + "/" + zahlb + " = " + (zahla / zahlb));
                    break;

                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
