using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overrideBeispeil
{
    class Film13 : Film
    {
        public Film13(string titel, int bestand) : base(titel, bestand)
        {

        }

        public override bool DarfVerliehenWerden(int alt)
        {
            if (alt >= 13) //Individueller Code
            {
                return true;
            }
            return false;
        }


    }
}
