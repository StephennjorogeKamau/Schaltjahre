using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung3
{
    class Program
    {
        class Werkstatt 
        {

            public List<Fahrzeug> fahrzeugs;
            public Werkstatt()
            {
                fahrzeugs = new List<Fahrzeug>();
            }
           
        }
        class Fahrzeug 
        { 
            public Fahrzeug()
            {
                string Name;
                string Model;
            }
        }
        class Wheels 
        {
          
            //public int tirediameter;
            //public string tiretype;
            //public string tireposition;
            public Wheels()
            {
                int tirediameter;
                string tiretype;
                string tireposition;
                     
            }

        }
       class Lkw : Fahrzeug
        {

            public Lkw()
            {
                string Name;
            }
        }
        class Pkw : Fahrzeug
        {
            
        }
        class Motorrad : Fahrzeug
        {
            
        }
        
        static void Main(string[] args)
        {
            //Werkstatt abfrage

            Console.WriteLine("Auto auswahlen");
            //Lkw lkw1 = new Lkw("FH", 2016);

            Werkstatt werkstatt = new Werkstatt();
            werkstatt.fahrzeugs()
            
           
            

            //List<Fahrzeug> fahrzeugs = new List<Fahrzeug>();




            Console.ReadLine();
        }
    }
}
