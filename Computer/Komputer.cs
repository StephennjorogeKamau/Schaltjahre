using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer
{
    class Komputer
    {
        //Felder
        public string name;
        public string prozessor;
        public string ram;
        public int hdd;

        //Konstrucktor
        public Komputer() { }

        //Hochfahren
        static void ComputerHochFarhren()
        {
            Console.WriteLine("Hoch Fahren Erfolgrich");
        }

        //Herunterfahren
        static void ComputerHerunterFarhren()
        {
            Console.WriteLine("HerunterFahren Erfolgrich. Tchüss!");
        }

        static void Main(string[] args)
        {
            Komputer comp = new Komputer()
            {
                name = "IBM",
                prozessor = "Core i9 intel Atom",
                ram = "8GB",
                hdd = 500
            };
            Console.WriteLine("wählen sie ihre computer");
            Console.WriteLine("1. IBM");
            int userinput = Convert.ToInt32(Console.ReadLine());
           if (userinput == 1)
            {
                Console.WriteLine("O. Hoch Fahren");
                Console.WriteLine("X. HerunterFahren");
                string eingabe = Console.ReadLine();
                if (eingabe == "o")
                {
                    Komputer.ComputerHochFarhren();
                }

            }
            Console.ReadLine();

        }
    }
}
