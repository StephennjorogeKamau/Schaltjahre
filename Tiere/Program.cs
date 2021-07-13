using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiere
{
    class Program
    {
        static void Main(string[] args)
        {
            Fish fisch = new Fish();
            fisch.preis = 10;
            fisch.Alter = 10;
            fisch.Ernaerung = "";
            fisch.NoetigesVolumen = 10;
            fisch.Farbe = "";
            fisch.Plartzhalter = "";

            Krustentier krustenTier = new Krustentier();
            krustenTier.preis = 10;
            krustenTier.Alter = 10;
            krustenTier.Ernaerung = "";
            krustenTier.NoetigesVolumen = 10;
            krustenTier.Plartzhalter1 = "";

            Hunde hund = new Hunde();
            hund.preis = 10;
            hund.Alter = 10;
            hund.Ernaerung = "";





        }
    }
}
