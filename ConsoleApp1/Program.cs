using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nummer2 = new int[10];

            for (int i = 50; i <= 59; i++)
            {
                nummer2[i - 50] = i;
            }
            foreach (int item in nummer2)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
