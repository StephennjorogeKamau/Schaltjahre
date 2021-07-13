using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalt_Heis_internet_copied
{
    class Program
    {
        static void Main(string[] args)
        {
            string eing;
            int geraten;
            int geheim;
            int versuche = 0;
            Random zufall = new Random();
            geheim = zufall.Next(101);
            do
            {
                Console.Write("Zahl eingeben (0-100): ");
                eing = Console.ReadLine();
                geraten = Convert.ToInt32(eing);

                if (geraten < geheim)
                {
                    Console.WriteLine("Eingabe zu klein");
                }
                if (geraten > geheim)
                {
                    Console.WriteLine("Eingabe zu groß");
                }
                versuche = versuche + 1;
            } while (geraten != geheim && versuche < 6);

            if (geraten == geheim)
            {
                Console.WriteLine("Super! Du hast nur " + versuche
                + " Versuche benötigt");
            }
            else
            {
                Console.WriteLine("Verloren es wäre " + geheim
                    + " gewesen!");
            }
            Console.ReadKey();
            
        }
    }
}
