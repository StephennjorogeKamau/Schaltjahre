using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie_Aufgabe
{
    class Mitarbeiter : Person
    {
        private decimal Gehalt;

        public override void gehalt()
        {
             Gehalt = (Gehalt * 1.19m);
        }


    }
}
