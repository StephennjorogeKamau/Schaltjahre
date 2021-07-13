using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trial
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] lotto2 = new int[7];
            int check = 0;

            Random rand = new Random();

            for (int i = 0; i < lotto2.Length; i++)
            {
                check = rand.Next(1, 46);

                while (!(lotto2.Contains(check))) //Was passiert wenn Element bereits im Array?
                {
                    lotto2[i] = check;
                }
                Console.Write(" " + lotto2[i]);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}