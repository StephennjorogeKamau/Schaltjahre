using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    class Auto
    {

        public string marke; // so dass wir es an usere pragramm verwendet kann
        public string model;
        public int baujahr;
        public string farbe;
        public int ps;
        public double kilometerstand;

        //Methoden

        public void Zusammenfasung()
        {
            Console.WriteLine(
           $"marke:{marke} \n" +   // \n = neue seile
               $"Modell:{model}\n" +
               $"Baujahr:{baujahr}\n" +
               $"Farbe:{farbe}\n" +
               $"ps: {ps}\n" +
               $"Kilometerstand: {kilometerstand}"
                );
        }
        public string Zusammenfasung1()
        {
            string reuckgabe;
            reuckgabe = $"marke:{marke} \n" +   // \n = neue seile
               $"Modell:{model}\n" +
               $"Baujahr:{baujahr}\n" +
               $"Farbe:{farbe}\n" +
               $"ps: {ps}\n" +
               $"{kilometerstand}";
            return reuckgabe;
        }
        public void Summekmstand(double plus)
        {
            kilometerstand = kilometerstand + plus;//kilometerstand += plus
        }
    }
}
