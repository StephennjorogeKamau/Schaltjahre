using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overrideBeispeil
{
   abstract class Film // Basis Klasse die selvber nie instanziert werden darf.
        //notwendig um abstrakte Methoden zu definieren.
    {
        public const decimal PreisProTag = 1.5m; // Ein Konstanter Wert der alle Member 
        //von Film und allen kinder von Film verfügbar ist; consta ist immer static.

        public string Titel;// normale public Felder sind in allen Instanzen 
                            //von kinder verfügbar
        public int Bestand;

        public Film (String titel, int bestanden) // Konstruktor in der Kinder Klassen 
        {
            Titel = titel;
            Bestand = bestanden;

        }

        public void Aufstocken (int menge)// normale public Method ist in allen Instanzen von Kinder Klassen
            //von Flim verfügbar
        {
            Bestand += menge;
        }

        public virtual decimal PreisBerechnen(int tage) // Virtual Methoden sind unverändert von allen Kínder 
            // klassen, können aber wenn nötig überSchrieben (override) werden. In diesem Beispiel benutzen
           //3 von 4 Klassen diese Method wie sie ist und eine von den kinder Klassen benutzen den override 
           //um eine andere Berechnung durchzuführen 
            //
        {
            return tage * PreisProTag;
        }

        public abstract bool DarfVerliehenWerden(int alt); // abstract Methoden müssen von jeder Kinder Klasse
        // überschrieben werden; die definition hier erzwingt das alle Kinder Klassen diese Methode besitzen
        // der tatsächliche Code ist individuell für jede Klasse und kann in einer Basis Klasse NICHT definiert werden.


    }
}
