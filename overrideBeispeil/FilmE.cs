using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overrideBeispeil
{
    class FilmE : Film // FilmE ist abgeleitet vom Film, FilmE ist die Kinder Klasse von Film
    {
        public FilmE(string titel, int bestand) : base(titel ,bestand)// FilmE hat einen Konstruktor der 2
            // parameter verlangt und diesen den Konstruktor seiner Basis Klasse aufruft.
        {

        }

        public override bool DarfVerliehenWerden(int alt) // diese Methode in der Basis Klasse abstract ist 
            //MUSS FilmE diese Methode mit override implementieren.
        {
            return true; //Individueller Code.
        }


    }
}
