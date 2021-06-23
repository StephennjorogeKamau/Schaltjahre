using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schaltjahre
{
    class Program
    {
        static void Main(string[] args)
        {
            //////variablen
            int erg;
           

            Eingabe
            Console.WriteLine("Bitte geben Sie ein Jahr ein: ");
            erg = int.Parse(Console.ReadLine());

            //Rechnung

            for (int i =1900 ; i < 2050; i ++)
            {
                if (i  % 400 == 0)
                {
                    Console.WriteLine(" Dieses Jahres ist Schaltjahre ");
                }
            }
            
            Console.WriteLine();
            Console.WriteLine("Beenden.... ");
            Console.ReadKey();
        }
    }
}
