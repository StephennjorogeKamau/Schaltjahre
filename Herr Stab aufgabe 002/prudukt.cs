using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herr_Stab_aufgabe_002
{
    class prudukt
    {
        public string Bezeichnen;
        public decimal Nettopreis;
        public int Bestant;

        public decimal Brutto()
        {

          decimal brutto = Nettopreis * (1 + 0.19m);
            return brutto;
        }

    }
}
