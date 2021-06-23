using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statischesmember
{
    class Program
    {
        static void Main(string[] args)
        {

            //Statisches Methoden
            Console.WriteLine(Meinemethoden.Meinzahl);
            Console.WriteLine(Meinemethoden.Addierer(5, 2));

            Console.ReadKey();
        }
    }
}
