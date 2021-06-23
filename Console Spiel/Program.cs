using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Spiel
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable
            Random Braketnummmer = new Random();
            int Gehim, Raten, Eingabe;
            bool check;

            //declaration
            Gehim = Braketnummmer.Next(1, 101);

            //Eingabe Zahl 1
            do
            {
            Console.Write("Bitte geben Sie Erste Zahl Ein. ");
            check =int.TryParse(Console.ReadLine(),out Eingabe);
            if (!check)
            {
                Console.WriteLine("Bitte nur Zahl eingeben.");
            }
            } while (!check);


            //Hard or Easymode

            //Ausgabe

            Console.ReadKey();
        }
    }
}
