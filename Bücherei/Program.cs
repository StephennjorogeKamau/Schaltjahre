using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bücherei
{
    class Program
    {
        static void Main(string[] args)
        {
            //variablen
            string Titel, Autor, Genre, ISBN;
            bool check;
            Buch1[] buecher = new Buch1[5];

            buecher[0] = new Buch1("More of you", "Paul B", "Spiritual", "(444-551-5568)", true);
            buecher[1] = new Buch1("Bold and Brave", "Brian Bale", "Kinder", "(551-5568-1458)", true);
            buecher[2] = new Buch1("Wisennheit", "Tobias Hertz", "Science", "(551-444-5568)", true);
            buecher[3] = new Buch1("Dissel Skandal", "Lina Schatzle", "General", "(4587-5698-556-1254)", false);
            buecher[4] = new Buch1("Ich Liebe es", "Mari Zackozi", "Romance", "(2581-3698-5568)", false);
            

            //for (int i = 0; i < buch.Length; i++)
            //{
            //    Console.WriteLine("Bitte Titel eingeben: ");
            //    Titel = Console.ReadLine();
            //    Console.WriteLine("Bitte Autor eingeben: ");
            //    Autor = Console.ReadLine();
            //    Console.WriteLine("Bitte Genre eingeben: ");
            //    Genre = Console.ReadLine();
            //    Console.WriteLine("Bitte ISBN eingeben: ");
            //    ISBN = Console.ReadLine();

            //    do
            //    {
            //        Console.WriteLine("ist das Buch Verliehen?");
            //        if (true)
            //        {

            //        }
            //    } while (true);
            //}


            //Buch1 bucha = new Buch1("Oma Und Opa", "Matius Ben", "Witz", "AGH-1245-2021.", true);
            //Console.WriteLine("Buch 1");
            //bucha.AusgabeBuch(); 






            Console.ReadKey();


        }
         
    }
}
