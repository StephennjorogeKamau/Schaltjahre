using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnervetwaltung
{
    class ITVerwaltung 
    {
        //Alle Rechner zu enthält.
        //Rechner[] rechners = new Rechner[5];

        //konstruktor
        //public ITVerwaltung()
        //{
        //    rechners = new Rechner[5];
        //}

        // Liste für Alle Rechner zu enthält.

        public List<Rechner> computersList = new List<Rechner>();
        public int counter = 0;

      

        public void RechnerZähler()
        {
            foreach (Rechner item in computersList)
            {
                Console.WriteLine(item);
            }
        }
        public void RechnerHinzufügen(Rechner r)
        {
            computersList.Add(r);
            counter++;
        }
        public void RechnerEntfern(Rechner r)
        {
            computersList.Remove(r);
            counter--;
        }

    }
}
