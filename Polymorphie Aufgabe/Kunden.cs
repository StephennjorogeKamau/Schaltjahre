using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie_Aufgabe
{
    class Kunden : Person
    {
        public string Lieblingsprodukt;

        public override bool Equals(object obj)
        {
            return obj is Kunden kunden &&
                   GeburtsDatum == kunden.GeburtsDatum &&
                   Lieblingsprodukt == kunden.Lieblingsprodukt;
        }



        //Konstructor

    }
}
