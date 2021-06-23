using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklaration

            DateTime dt = new DateTime(2021, 02, 15, 8, 15, 32);
            DateTime dt2 = new DateTime(2020, 8, 14);
            DateTime dt3 = DateTime.Now;
            DateTime dt4 = new DateTime(2020, 9, 10);

            Console.WriteLine(dt);
            Console.WriteLine();

            //nur Datum
            Console.WriteLine(dt.ToShortDateString());
            Console.WriteLine(dt.ToLongDateString());
            Console.WriteLine();

            //nur Uhrzeit
            Console.WriteLine(dt.ToLongTimeString());
            Console.WriteLine(dt.ToShortTimeString());
            Console.WriteLine();

            //dt2
            Console.WriteLine(dt2);
            Console.WriteLine();


            //Tagesausgaben
            Console.WriteLine(dt2.DayOfWeek);
            Console.WriteLine();

            if (dt2.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("Sunday");  
            }
            else
            {
                Console.WriteLine("Keine Sunday");
            }


            Console.ReadKey();
        }
    }
}
