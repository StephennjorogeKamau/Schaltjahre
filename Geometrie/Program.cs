using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    class Program
    {
        static void Main(string[] args)
        {
            Kries kreis1 = new Kries();
            kreis1.radius = 3.5;
            Console.WriteLine($"Radius: {kreis1.radius}");

            double r1 = 8.6;
            Kries kreis2 = new Kries();
            Console.WriteLine($"Radius: {kreis2.radius}");

            Console.WriteLine();
            Console.WriteLine(kreis1.zussamenfassung());

            Console.WriteLine();
            Console.WriteLine(kreis2.zussamenfassung());






           

        }
    }

}
