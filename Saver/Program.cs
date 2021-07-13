using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saver
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variablen
            Random geheim = new Random();
            //i
            //j
            //int versuche = ?;
            bool check;

            //And Zahl liegt zwichen 1 && 100
            //If rheifall ()<==warm ()==> Kalt.

            for (int i = 0; i < 6; i++)
            {
                do
                {
                    //Eingabe
                    Console.Clear();
                    Console.Write("Geben Sie ein Zahl zwichen 1-100: ");
                    Console.WriteLine();
                    check = int.TryParse(Console.ReadLine(), out eingibt[i]);
                    if (eingibt[i] < 1 || eingibt[i] > 100)
                    {
                        check = false;
                        Console.WriteLine("Bitte geben Sie Ziffer zwichen 1 - 100 ein");
                        Console.WriteLine();
                        Console.WriteLine("Beliebinde Taste Drucken");
                        Console.ReadLine();
                    }
                } while (true);

                ////Erraten Ziehung
                for (int j = 0; j < 6; j++)
                {
                    do
                    {
                        check = true;
                        erraten[j] = rnd.Next(1, 101);
                        for (int versuche = j + 1; versuche >= 0; versuche++)
                        {
                            if (erraten[j] == versuche)
                                check = false;
                        }
                    } while (!check);
                }
            }


            Console.ReadKey();
        }
    }
}
