using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiere
{
    abstract class Tier
    {
        public decimal preis;
        public int Alter;
        public string Ernaerung;

        public Tier(decimal preis, int alter, string ernaerung)
        {
            this.preis = preis;
            Alter = alter;
            Ernaerung = ernaerung;
        }
    }
}
