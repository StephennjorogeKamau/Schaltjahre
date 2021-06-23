using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statischesmember
{
   static class Meinemethoden // eine statidche klasse kann nur statische Felder, Methoden, usw. beihalten.
    {
        public static int Meinzahl;

        private static int NocheineZahl;


        public static int Addierer(int a, int b) 
        {
            NocheineZahl = 10;
            return a + b;
        }
    }
}
