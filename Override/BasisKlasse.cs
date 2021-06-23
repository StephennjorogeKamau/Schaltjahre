using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override
{
    class BasisKlasse
    {
        public void NichtUebersschreibareMethod()
        {
            Console.WriteLine("ich nin nicht überschreibar");
        }

        public virtual void MethodeDieUeberschreibenWerdenKANN()
        {
            Console.WriteLine("Ich  kann übershreiben werden"); //Dieser Code wird
        }

        public virtual void NichtUebersschreibareMethod(string text)
        {
            Console.WriteLine("ich kann  überschreiben werden mit: " + text);
        }


    }
}
