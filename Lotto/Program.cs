using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array
            Random rnd = new Random();
            int[] intLotto = new int[6];        //i Lottoziehung
            int[] Ausgabe = new int[6];         //j Eingabe
            bool check;
            DateTime aktDatum = DateTime.Now;
            //User Eigabe

            do
            {

                check = true;
                Console.Write(" Zuerst Nummer eingeben: ");
                check = int.TryParse(Console.ReadLine(), out eingabe1);
                if (eingabe1 == 0)
                {
                    check = false;
                    Console.WriteLine();
                    Console.WriteLine("Bitte nur 1 bis 49 eingeben.");
                }
                else if (eingabe1 > 49)
                {
                    check = false;
                    Console.WriteLine();
                    Console.WriteLine("Bitte nur 1 bis 49 eingeben.");
                }


            } while (!check);

            do
            {
                
                check = true;
                Console.Write(" Zweite Nummer eingeben: ");
                check = int.TryParse(Console.ReadLine(), out eingabe2);
                if (eingabe2 == 0 )
                {
                    check = false;
                    Console.WriteLine();
                    Console.WriteLine("Bitte nur 1 bis 49 eingeben.");
                }
                else if (eingabe2 > 49)
                {
                    check = false;
                    Console.WriteLine();
                    Console.WriteLine("Bitte nur 1 bis 49 eingeben.");
                }

            } while (!check);

            do
            {
                check = true;
                Console.Write(" Dritte Nummer eingeben: ");
                check = int.TryParse(Console.ReadLine(), out eingabe3);
                if (eingabe3 == 0)
                {
                    check = false;
                    Console.WriteLine();
                    Console.WriteLine("Bitte nur 1 bis 49 eingeben.");
                }
                else if (eingabe3 > 49)
                {
                    check = false;
                    Console.WriteLine();
                    Console.WriteLine("Bitte nur 1 bis 49 eingeben.");
                }
            } while (!check);

            do
            {
                check = true;
                Console.Write(" Vierte Nummer eingeben: ");
                check = int.TryParse(Console.ReadLine(), out eingabe4);
                if (eingabe4 == 0)
                {
                    check = false;
                    Console.WriteLine();
                    Console.WriteLine("Bitte nur 1 bis 49 eingeben.");
                }
                else if (eingabe4 > 49)
                {
                    check = false;
                    Console.WriteLine();
                    Console.WriteLine("Bitte nur 1 bis 49 eingeben.");
                }

            } while (!check);

            do
            {
                check = true;
                Console.Write(" Fünfte Nummer eingeben: ");
                check = int.TryParse(Console.ReadLine(), out eingabe5);
                if (eingabe5 == 0)
                {
                    check = false;
                    Console.WriteLine();
                    Console.WriteLine("Bitte nur 1 bis 49 eingeben.");
                }
                else if (eingabe5 > 49)
                {
                    check = false;
                    Console.WriteLine();
                    Console.WriteLine("Bitte nur 1 bis 49 eingeben.");
                }
            } while (!check);

            do
            {
                check = true;
                Console.Write(" Sechste Nummer eingeben: ");
                check = int.TryParse(Console.ReadLine(), out eingabe6);
                if (eingabe6 == 0)
                {
                    check = false;
                    Console.WriteLine();
                    Console.WriteLine("Bitte nur 1 bis 49 eingeben.");
                }
                else if (eingabe6 > 49)
                {
                    check = false;
                    Console.WriteLine();
                    Console.WriteLine("Bitte nur 1 bis 49 eingeben.");
                }
            } while (!check);


            Console.WriteLine();
            Console.WriteLine("VIEL GLÜCK: ");
            Console.WriteLine();
            Console.WriteLine("Bitte Enter Taste Drucken. ");
            Console.ReadLine();
            Console.WriteLine("Glücksspiel kann süchtig machen, bitte spielen Sie verantwortungsbewusst.");
            Console.WriteLine("=========================================================================");
            Console.WriteLine();
            Console.WriteLine("Datum :" + aktDatum.ToLongDateString());
            Console.WriteLine();
            Console.Write("Ihr Eingabe: " + (eingabe1, +eingabe2, +eingabe3, +eingabe4, +eingabe5, +eingabe6));
            Console.WriteLine();
            Console.WriteLine("===========================================================================");
            Console.WriteLine();
            //Inhalt 
            for (int i = 0; i < intLotto.Length; i++)
            {
                 int Lotto = rnd.Next(1, 50);
                Console.WriteLine(Lotto);
                Console.WriteLine();
            }
            //Vergleichen.
            

            Console.WriteLine();
            Console.WriteLine(" versuchen Sie wieder Y/N.");
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
