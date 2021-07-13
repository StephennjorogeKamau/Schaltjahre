using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override
{
    class Kinder1 : BasisKlasse
    {

        public override void MethodeDieUeberschreibenWerdenKANN()
        {
            Console.WriteLine("Ich wurde von KinderKlasse1 überschreibar");
            base.MethodeDieUeberschreibenWerdenKANN();
        }


    }
}
