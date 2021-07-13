using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objekt_Orient_Programm
{
    class Program
    {
        static void Main(string[] args)
        {
            Buch b1 = new Buch();
            Buch b2 = new Buch();
            Buch b3 = new Buch();

            b1.titel = "Vom Einde verweht";
            b2.titel = "Neuomancer";
            b3.titel = "20.000 Meilen unter dem Meer";


            b1.Aufgabetitel();
            b2.Aufgabetitel();
            b3.Aufgabetitel();


            



            Console.ReadKey();
        }
    }
}
