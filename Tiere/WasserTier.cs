using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiere
{
    class WasserTier : Tier
    {
       protected string WasserArt;
        public double NoetigesVolumen;

        public WasserTier(decimal preis, int alter, string wasserArt, double noetigesVolumen)
        {
            WasserArt = wasserArt;
            NoetigesVolumen = noetigesVolumen;
        }
    }
}
