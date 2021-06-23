using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasse_Person
{
    class Person
    {
        //felder
        public string Vorname;
        public string Nachname;
        public int Geburtsjahr;
        public char Geschlecht;
        public double Körpergewicht;
        public double Grouss;
        public bool check;
        public DateTime dateTime;

        ////public double Ergebnis()
        ////{
        ////    double bmi = Körpergewicht / ((Grouss / 100) * (Grouss / 100);
        ////2hoch 7= 2 to the power of 7;
        ////double bmi = Körpergewicht / Math.Pow / 100 * 2);
        ////reteun bmi;
        //// return Math.Round (gewicht / Math.Pow(groesse * 1.0 /100, 2), 2);
        ////}

        public double Bmi()
        {

            return Math.Round(Körpergewicht / Math.Pow(Grouss * 1.0 / 100, 2), 2);

        }


        public string zusammenfasung()
        {
            return
                $"Nachname: {Nachname} \n" +
            $"Vorname: {Vorname} \n" +
            $"Geburtsjahr: {Geburtsjahr} \n" +
            $"Geschlecht: {Geschlecht} \n" +
            $"Körpergewicht (kg): {Körpergewicht} \n" +
            $"Grouss (cm): {Grouss}\n" +
            $"BMI: {Bmi()}\n" +
            $"kcal_bedarf: {Kcal()}";
        }


        /* Grundumsatz an Kilokalorien (kcal) pro Tag
https://www.smart-rechner.de/kcal_bedarf/rechner.php
* https://wie-viele-kalorien-am-tag.de/harris-benedict-formel-grundumsatz-berechnen/
* Aktuelles Jahr: 2020: DateTime.Now.Year
Formel für Männer:
66,47 + (13,7 * Körpergewicht in kg) + (5 * Körpergröße in cm) -
(6,8 * Alter in Jahren)

Formel für Frauen:
655,1 + (9,6 * Körpergewicht in kg) + (1,8 * Körpergröße in cm) -
(4,7 * Alter in Jahren)
*/

        //Rechnen
        public double Kcal()
        {
            double grundumsatz = 66.47 + (13.7 * Körpergewicht) + (5 * Grouss) - (6.8 * (2012 - Geburtsjahr));
            return grundumsatz;
        }



    }
}
