using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objekt_Orient_Programm
{
     class Buch 
    {
        public string titel;
        public string autor;
        public string isbn;
        public string genre;
        public int erscheinungsjahr;


        public Buch(string titel)
        {
            this.titel = titel;
        }

        public Buch() { }

        //methoden
        public void Aufgabetitel() 
        {
            Console.WriteLine("Der Titel " + titel);
        }



    }

}
