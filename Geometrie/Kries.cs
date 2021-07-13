using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    class Kries
    {
        public double radius;


        /* Wenn in einer Klasse KEIN Konstruktor definiert wird, wird
        * automatisch der Standardkonstruktor verwendet.
        * 
        * Wenn ein eigener Konstruktor definiert wird, wird der Standard-
        * konstruktor NICHT mehr automatisch angelegt.
        * */

        public Kries()
        {

        }
        public Kries(double r, double Umfang, double fläche)
        {
            radius = r;
            Umfang = (Math.PI * r * 2);
            fläche = (Math.PI * r * r);
        }

        /* 
         1.Methode: Ergebnis: Umfang eines Kreises.
         2. Methode: Ergebnis: Fläche eines Kreises.
        */
        public double umfangKreise()
        {
            return 2 * Math.PI * radius;
        }

        public double flächekreise()
        {
            return Math.PI * radius * radius;
            //return Math.PI * Math.Pow(radius, 2);
        }
        public string zussamenfassung()
        {
            return $"Radius: {Math.Round(radius, 2)}\n" +
                   $"Umfang: {Math.Round(umfangKreise(), 2)}\n" +
                   $"Fläche: {Math.Round(flächekreise(), 2)}";
        }


    }
}
