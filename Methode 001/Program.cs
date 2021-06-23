using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methode_001
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Eingabe = new int[5] { 5, 6, 9, 2, 8 };
            int temp;

            //Erster Eingabe.

            Console.WriteLine("Erster Eingabe");
            foreach (int item in Eingabe)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            temp = Eingabe[0];
            Eingabe[0] = Eingabe[2];
            Eingabe[2] = temp;

            Console.WriteLine("Ausgabe");
            foreach (int item in Eingabe)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------");


            //Alle in eine array
            int[] steve = new int[6] { 8, 7, 3, 9, 5, 1 };
            Console.WriteLine(" Before");
            foreach (int item in steve)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            int z1 = 2, z2 = 4;
            Tauschen(steve, z1, z2);
            Tauschen(steve, 1, 2);

            Console.WriteLine("Afterwards");
            foreach (int item in steve)
            {
                Console.Write(item + " ");

            }
            Console.WriteLine();

            Console.ReadKey();
        }
        static void Tauschen(int[] array, int y1, int y2)
        {
            int temp = array[y1];
            array[y1] = array[y2];
            array[y2] = temp; 
        }



    }
}


