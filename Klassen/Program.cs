using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    class Program
    {
        static void Main(string[] args)
        {
            //int zahl;
            int[] zahlen = new int[5];
            Auto auto1 = new Auto(); //Instanzierung mit Schlüsselwort new
            auto1.marke = "VW";
            auto1.model = "Golf";
            auto1.baujahr = 2012;
            auto1.farbe = "Weiß";
            auto1.ps = 110;
            auto1.kilometerstand = 1223.225;

            Console.WriteLine();
            Console.WriteLine("Auto 1");
            Console.WriteLine(
                "marke: " + auto1.marke + "\n" +   // \n = neue seile
                "Modell: " + auto1.model + "\n" +
                "Baujahr: " + auto1.baujahr + "\n" +
                "Farbe: " + auto1.farbe + "\n" +
                "ps: " + auto1.ps
                );
            Console.WriteLine("11111111111111111111111111111111111111111");
            Console.WriteLine();
            Console.WriteLine("Auto 1");
            Console.WriteLine(
                $"marke:{auto1.marke} \n" +   // \n = neue seile
                $"Modell:{auto1.model}\n" +
                $"Baujahr:{auto1.baujahr}\n" +
                $"Farbe:{auto1.farbe}\n" +
                $"ps: {auto1.ps}"
                );
            Console.WriteLine("Auto 1");
            Console.WriteLine("222222222222222222222222222222222222222222222");

            //Auto2
            Auto auto2 = new Auto();
            auto2.marke = "BMX";
            auto2.model = "X4";
            auto2.baujahr = 2015;
            auto2.farbe = "Schwarz";
            auto2.ps = 400;
            auto2.kilometerstand = 12548.2;

            //Auto 3
            Auto auto3 = new Auto();
            auto3.marke = "Toyota";
            auto3.model = "Yaris";
            auto3.baujahr = 2010;
            auto3.farbe = "Rot";
            auto3.ps = 110;
            auto3.kilometerstand = 122533.2;
            Console.WriteLine();

            Console.WriteLine("Auto 1: ");
            auto1.Zusammenfasung();

            Console.WriteLine();
            Console.WriteLine("Auto 2: ");
            auto2.Zusammenfasung();

            Console.WriteLine();
            Console.WriteLine("auto 3: ");
            auto3.Zusammenfasung();
            Console.WriteLine("3333333333333333333333333333333333333333333333333333333");

            Console.WriteLine("AddierenKmstand");
            Console.WriteLine("Auto 2: ");
            Console.WriteLine($"Alter kilometerstand: {auto2.kilometerstand}");
            auto2.Summekmstand(1000);
            Console.WriteLine($"Neue Kilometerstand: {auto2.kilometerstand}");



            Console.ReadKey();
        }
    }
}
