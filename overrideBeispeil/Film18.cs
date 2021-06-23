using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overrideBeispeil
{
    class Film18 : Film
    {
        public Film18 (string titel, int bestanden) : base(titel ,bestanden)
        {

        }

        public override decimal PreisBerechnen(int tage) // die virtual Methode aus der Basis Klasse KANN überschrieben
         // werden; in diesem Beispiel soll hier eine andere Rechnung durchgeführt werden
        {
            return tage * (PreisProTag + 0.5m);
        }

        public override bool DarfVerliehenWerden(int alt)
        {
            if (alt >= 18)
            {
                return true;
            }
            return false;
        }


    }
}
