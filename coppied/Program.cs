using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coppied
{
    class Program
    {
        static void Main(string[] args)
        {
            var meinArray = new ArrayInt(5);

            // Compiler wandelt folgende Zeile um in
            // meinArray.this[0].set(2)
            meinArray[0] = 2;
            meinArray[1] = 3;
            meinArray[2] = 5;
            meinArray[3] = 7;
            meinArray[4] = 11;

            int a = meinArray[3];

            for (int i = 0; i < meinArray.Length; i++)
            {
                meinArray[i] = i * 10;
            }

            // Dank IEnumarable können wir auf dem selbsdefinierten Array mittels 
            // einer foreach- Schleife iterieren

            foreach (int elem in meinArray)
            {
                Debug.WriteLine(elem);
            }

            int sum = 0;
            for (int i = 0; i < meinArray.Length; i++)
                // Compiler wandelt folgende Zeile um in
                // meinArray.this[i].get()
                sum += meinArray[i];

            // jetzt den generischen Typ nutzen
            var PreislisteGen = new ArrayGenerisch<Preis>(3);

            PreislisteGen[0] = new Preis(4, 99);
            PreislisteGen[1] = new Preis(1, 99);
            PreislisteGen[2] = new Preis(2, 29);

            var p1 = PreislisteGen[1];


            var A8 = new ArrayGenerisch<Basics._04_Objektorientiert.Autobahn.Auto>(3);

            //A8[0].tanken(100);

            var deinArray = new ArrayGenerisch<double>(3);

            deinArray[0] = 3.14;
            deinArray[1] = 2.72;
            deinArray[2] = 9.81;

            // deinArray ist streng typisiert
            //deinArray[2] = "Hallo";

            double dblSum = 0;
            for (int i = 0; i < deinArray.Length; i++)
                dblSum += deinArray[i];


            // Vorgefertigte generische Collections einsetzen

            // 1) List- ein dynamischer Ersatz für Arrays
            var Preisliste = new List<Preis>(10);

            FüllePreisliste(Preisliste);

            // Compiler wandelt folgenden Aufruf um in
            // Preisliste.this[3].get()
            var preis3 = Preisliste[3];
            Assert.AreEqual(8, preis3.GetEuro());
            Assert.AreEqual(8, Preisliste[3].GetEuro());

            // Einen Preis aus der Liste entfernen
            Preisliste.RemoveAt(0); // 1. Element entfernen
            Preisliste.RemoveAt(Preisliste.Count - 1); // letztes Element entfernen
            Preisliste.RemoveRange(1, 2);

            FüllePreisliste(Preisliste);

            // Linked List
            var AktuellePreise = new LinkedList<string>();
            foreach (var p in Preisliste)
            {
                AktuellePreise.AddLast(p.ToString());
            }

            foreach (var el in AktuellePreise)
            {
                Debug.WriteLine(el);
            }

            // Iterieren über die LinkedList vorwärts
            LinkedListNode<string> actNode = null;
            for (actNode = AktuellePreise.First; actNode != null; actNode = actNode.Next)
            {
                Debug.WriteLine("preis: " + actNode.Value);

            }

            // Iterieren über die LinkedList rückwärts
            for (actNode = AktuellePreise.Last; actNode != null; actNode = actNode.Previous)
            {
                Debug.WriteLine("preis: " + actNode.Value);

            }

            foreach (var p in AktuellePreise)
            {
                // Current greift auf Value vom Node zu
                Debug.WriteLine("preis: " + p);
            }


            // 2 PReise entfernen
            Preisliste.Remove(new Preis(12, 45));

            // den 3. Preis entfernen
            Preisliste.RemoveAt(3);


            AktuellePreise.Clear();
            foreach (var p in Preisliste)
            {
                AktuellePreise.AddLast(p.ToString());
            }

            // Telefonbuch
            var telBuch = new Dictionary<string, int>();

            telBuch.Add("Anton", 4711);

            // neuer Eintrag hinzugefügt, da noch nicht unter dem Schlüssel vorhanden
            // Folgeder Indexeraufruf entspricht telbuch.Add("Berta", 6969);
            telBuch["Berta"] = 6969;

            // Eintrag geändert
            telBuch["Berta"] = 7766;

            telBuch["Cäsar"] = 3344;

            // Iterieren durch Dictionary 1
            var telBuchListe = new LinkedList<string>();
            foreach (var k in telBuch.Keys)
            {
                telBuchListe.AddLast(k + ": " + telBuch[k]);
            }

            // Iterieren durch Dictionary 2
            telBuchListe.Clear();
            foreach (KeyValuePair<string, int> pair in telBuch)
            {
                telBuchListe.AddLast(pair.Key + ": " + pair.Value);
            }

            // Queue

            var Warteschlange = new Queue<Tuple<int, string>>();


            // Aufträge in Warteschlange einstellen
            Warteschlange.Enqueue(new Tuple<int, string>(99, "Abwaschen"));
            Warteschlange.Enqueue(new Tuple<int, string>(77, "Abtrocknen"));
            Warteschlange.Enqueue(new Tuple<int, string>(66, "Wegräumen"));

            // Jobverarbeitung schaltet sich ein
            var Auftragsprotokoll = new LinkedList<string>();
            var Auftrag = Warteschlange.Dequeue();
            Auftragsprotokoll.AddLast("Führe aus: " + Auftrag.Item2);

            Warteschlange.Enqueue(new Tuple<int, string>(55, "Zumachen"));

            // Nachschauen, ohne zu entnehmen
            var erstes = Warteschlange.Peek();

            // Da die Queue IEnumerable implementiert, können alle aktuellen
            // Einträge mittels foreach- Schleife besucht werden
            foreach (var job in Warteschlange)
            {
                Debug.WriteLine(job.Item2);
            }

            var alleJobsDieMitABeginnen = Warteschlange.Where(r => r.Item2.StartsWith("A")).ToArray();

            Auftrag = Warteschlange.Dequeue();
            Auftragsprotokoll.AddLast("Führe aus: " + Auftrag.Item2);

            // Alle restlichen verarbeiten
            while (Warteschlange.Count > 0)
            {
                Auftrag = Warteschlange.Dequeue();
                Auftragsprotokoll.AddLast("Führe aus: " + Auftrag.Item2);





            Console.ReadKey();

        }
    }
}
