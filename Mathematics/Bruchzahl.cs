using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
   public class Bruchzahl
    {
        public int nenner;
        public int zehler;

        //public int MyProperty { get; set; }
        public void Zehlerwert(int z)
        {
            zehler = z;
        }

        public void Nennerwert(int n)
        {
            nenner = n;
        }

        //Bruchzahl to string Überschrieben
        public override string ToString()
        {
            return $"Bruchzahl {zehler / nenner}";
        }


    }
}
