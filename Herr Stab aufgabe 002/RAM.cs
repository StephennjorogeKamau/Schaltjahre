using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herr_Stab_aufgabe_002
{
    class RAM : prudukt
    {
        public int Kapazität;
        public int Taktung;

        //Ram aufgabe
        public decimal BruttoMitRabatt(int rabatt)
        {
            decimal nettoMitRabatt = Nettopreis * (1 + rabatt / 100);
            return nettoMitRabatt * 1.19m;
        }
        

    }
}
