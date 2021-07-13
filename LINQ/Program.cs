using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Produkt
    {
        //Felder
        public string name;
        public double preis;
        public int bestand;
        public string farbe;
        public int pnummer;

        public Produkt()
        {
        }
        public override string ToString()
        {
            return $"Produkt Name: {name}\nProdukt Preis: {preis} Euros\nLagerbestand: {bestand}\nFarbe: \t{farbe}\nProduktnummer: {pnummer}";
        }
    }

    public class InventoryControl
    {
        public static void Main()
        {
            //Listen von Produkten
            List<Produkt> produkts = new List<Produkt>();
            produkts.Add(new Produkt() { name = "Iphone 7s", preis = 350.99, bestand = 10, farbe = "Gold", pnummer = 001 });
            produkts.Add(new Produkt() { name = "Iphone 7 Plus", preis = 450.99, bestand = 5, farbe = "Black", pnummer = 002 });
            produkts.Add(new Produkt() { name = "Iphone XS", preis = 550.99, bestand = 6, farbe = "Rot", pnummer = 003 });
            produkts.Add(new Produkt() { name = "Iphone 8", preis = 590.99, bestand = 4, farbe = "White", pnummer = 004 });
            produkts.Add(new Produkt() { name = "Iphone 8s", preis = 599.99, bestand = 3, farbe = "Silver", pnummer = 005 });
            produkts.Add(new Produkt() { name = "Iphone 11", preis = 1020.99, bestand = 10, farbe = "Gold", pnummer = 006 });
            produkts.Add(new Produkt() { name = "Iphone 12", preis = 1268.28, bestand = 2, farbe = "Blau", pnummer = 007 });
            produkts.Add(new Produkt() { name = "Iphone 12 Plus", preis = 1568.99, bestand = 0, farbe = "Blau", pnummer = 008 });

            var produkt = new Produkt()
            {
                name = "Iphone 7"
            };


            //Neues produkt hinzufügen
            //User input Frage
            Console.WriteLine("Bitte Wahlen Sie Ihre Option an");
            Console.WriteLine();
            Console.WriteLine("1: Neuen Produkt Hinzufügen");
            Console.WriteLine("2: Produkte bestimmten Farbe");
            Console.WriteLine("3: Aller Produkt Abfragen");
            string userinput1 = Console.ReadLine();

            if (userinput1 == "3")
            {
                Console.WriteLine();
                Console.WriteLine("Bitte Wahlen Sie an");
                Console.WriteLine();
                Console.WriteLine("1: Aller Produkten auf Lager");
                Console.WriteLine("2: Nicht Lieferbar");
                Console.WriteLine("3: Gering verfügbar");
            }
            string userinput2 = Console.ReadLine();

            //Switch Verwende
            Console.Clear();
            switch (userinput1)
            {
                case "1":

                    break;
                case "2":

                    break;
                case "3":
                    if (userinput2 == "1")
                    {
                        for (var i = 0; i < produkts.Count; i++)
                        {
                            Console.WriteLine();
                            System.Console.WriteLine("{0}", produkts[i]);
                        }
                    }
                    else if (userinput2 == "2")
                    {
                        
                        //for (int bestand = 0; bestand < produkts.Count; bestand++)
                        //{
                        //    System.Console.WriteLine("{0}", produkts[bestand]);
                        //}
                    }
                    else if (userinput2 == "3")
                    {
                        //if ()
                        //{

                        //}
                    }
                    break;

                default:
                    Console.WriteLine("Belibiger Taste Drucken!");
                    break;
            }
            Console.ReadKey();


        }


    }
}
