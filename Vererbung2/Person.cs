using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung2
{
    class Person
    {
        public string Name, Gender, Ifor;
        public int Idnummer;


        class Lehrer : Person
        {
            public string subject;
        }

        class Schüller : Person
        {

        }

        
        public string GetPersonData()
        {
            return $"Name: {Name}\nGeschlecht: {Gender}\nNummer: {Idnummer}\nStatus: {Ifor}";
        }

        static void Main(string[] args)
        {
            Schüller person = new Schüller();
            person.Ifor = "Schüller";
            person.Name = "Di Maria";
            person.Gender = "Herr";
            person.Idnummer = 1;
            Console.WriteLine(person.GetPersonData());
            Console.WriteLine();

            Lehrer lehrer = new Lehrer();
            lehrer.Ifor = "Lehrer";
            lehrer.Name = "Müller";
            lehrer.Gender = "Frau";
            lehrer.Idnummer = 001;
            lehrer.subject = "Deutsch";
            //lehrer.subject = "Deutsch";
            Console.WriteLine(lehrer.GetPersonData());











            Console.ReadLine();
        }
    }
}
