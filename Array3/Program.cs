using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zahlen3 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 99; i >= 90; i--)
            {
                zahlen3[99 - i] = i;
            }

            foreach (int  item in zahlen3)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
}
