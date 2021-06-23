using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)

        {
            
            int[] nummer = new int[5];
            nummer[0] = 1;
            nummer[1] = 2;
            nummer[2] = 3;
            nummer[3] = 4;
            nummer[4] = 5;

            foreach (int item in nummer)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("=/=/=/=/=/=/=/=/=/=/=/=/=/==/=");

            Console.ReadKey();
        }
    }
}
