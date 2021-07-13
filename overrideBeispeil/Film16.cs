using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overrideBeispeil
{
    class Film16 : Film
    {

        public Film16(string titel, int bestand) : base(titel, bestand)
        {

        }

        public override bool DarfVerliehenWerden(int alt)
        {
            if (alt >= 16) // Individueller Code
            {
                return true;
            }
            return false;
        }
    }
}
