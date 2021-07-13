using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiere
{
    class Fish : WasserTier
    {
        public string Farbe;
        public string Plartzhalter;

        public Fish(decimal preis, int alter, string farbe, string plartzhalter)
        {
            Farbe = farbe;
            Plartzhalter = plartzhalter;
        }
    }
}
