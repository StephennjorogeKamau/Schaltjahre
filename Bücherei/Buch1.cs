using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bücherei
{
    class Buch1
    {
        //Feldeer
         private string titel;
         private string autor;
         private string genre;
         private string ISBN;
         private bool istVerliehen;

        //konstruktor.
        public Buch1 (string Titel, string Autor, string Genre, string isbn, bool istVerliehen)
        {
            this.titel = Titel;
            this.autor = Autor;
            this.genre = Genre;
            this.ISBN = isbn;
            this.istVerliehen = istVerliehen;
        }

        //Methoden
        public string AusgabeBuch() 
        {
            return $"Der Titel:{titel}\n" +
            $"Der Autor: {autor}\n" +
            $"Der Genre: {genre}\n" +
            $"Der ISBN: {ISBN}";
        }

        public override string ToString()
        {
            string v;
            if (istVerliehen == true) 
            {
                v = "verliehen";
            }
            else
            {
                v = " verfugbar";
            }
            return $"{titel} Von {autor}, {genre}, {ISBN}";
        }
        public static void Menu (Buch1[] beucher) 
        {
        
        }
        


         

}
    
}
