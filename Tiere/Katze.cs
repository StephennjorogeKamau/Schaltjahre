using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiere
{
    class Katze : Tier
    {
        private static string ernaerung;
        private static int alter;
        public string Rasse;
        public string Platzhalter1;
        private bool Platzhalter2;

        public Katze(decimal preis, int altter, string rasse, string platzhalter2) : base (preis, alter, ernaerung)
        {
            Rasse = rasse;
            Platzhalter1 = Platzhalter1;
            platzhalter2 = platzhalter2;
        }


    }
}
