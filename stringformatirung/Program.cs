using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringformatirung
{
    class Program
    {
        static void Main(string[] args)
        {
            //Varieblen
            Console.OutputEncoding = Encoding.UTF8;  // Erlaubt der Konsole € anzuzeigen

            double ausgabeZahl = 15.0 / 9;

            Console.WriteLine(ausgabeZahl); // Ausgabe der unformatierten Zahl ist unübersichtlich
            Console.WriteLine("Ihre Zahl hat den wert " + ausgabeZahl + ". Ziemlich lang..."); // unformatiert
            Console.WriteLine($"Ihre Zahl hat den wert{ausgabeZahl}. Ziemlich lang...."); // unformatiert
            Console.WriteLine("**********************************************************");

            //Formatirung von String
            // Syntax: {platzhalter:formatierung}
            // Standart (Vorgefärtigte) Formatierungen
            // https://docs.microsoft.com/de-de/dotnet/standard/base-types/standard-numeric-format-strings

            string formatext = string.Format("Ihre Zahl hat den wert {0:N2}. Ziemlich lang...", ausgabeZahl); // Anzahl (number) mit 2 Nachkommastellen
            Console.WriteLine(formatext);

            formatext = string.Format("Ihre Zahl hat den Wert {0:C3}. Ziemlich lang....", ausgabeZahl); // Wärung (currency) mit 3 Nachkommastellen
            Console.WriteLine(formatext);

            formatext = string.Format("Ihre Zahl hat den Wert {0:E3}. Ziemlich lang....", ausgabeZahl); // Exponentenschreibweise mit 3 Nachkommastellen
            Console.WriteLine(formatext);
            Console.WriteLine("**********************************************************");

            // Benutzerdefinbierte Formatierungen
            // https://docs.microsoft.com/de-de/dotnet/standard/base-types/custom-numeric-format-strings
            formatext = string.Format("Ihre Zahl hat den Wert {0:#.##}. Ziemlich lang...", ausgabeZahl); // # Platzhalter für Ziffern, vorrangehende und nachfolgende Nullen werden weg gelassen
            Console.WriteLine(formatext);

            formatext = string.Format("Ihre Zahl hat den Wert {0:#####.###€}. Ziemlich lang...", ausgabeZahl); // . Platzhalter für das Dezimaltrennzeichen
            Console.WriteLine(formatext);

            formatext = string.Format("Ihre Zahl hat den Wert {0:00000.###}. Ziemlich lang...", ausgabeZahl); // 0 Platzhalter für Ziffern, vorrangehende und nachfolgende Nullen werden ausgegeben
            Console.WriteLine(formatext);

            formatext = string.Format("Ihre Zahl hat den Wert {0:###.###E0}. Ziemlich lang...", ausgabeZahl); // E0 Platzhalter für den Exponenten
            Console.WriteLine(formatext);
            Console.WriteLine("**********************************************************");

            // Positionierung der wert.
            // Syntax: {platzhalter,minStellen}
            Random rng = new Random();

            // wenn man zusammenhängende Daten untereinander auflistet, kann es durch verschiedene Breiten
            // der Daten zu Unübersichtlichkeit führen
            string ausgabeText = string.Format("|{0}|", (rng.Next(0, 10) * Math.Pow(10, rng.Next(0, 10)))); // Random und Math.Pow nur für die generierung unteschiedlich breiter Zahlen Werte
            Console.WriteLine(ausgabeText);
            ausgabeText = string.Format("|{0}|", (rng.Next(0, 10) * Math.Pow(10, rng.Next(0, 10))));
            Console.WriteLine(ausgabeText);
            ausgabeText = string.Format("|{0}|", (rng.Next(0, 10) * Math.Pow(10, rng.Next(0, 10))));
            Console.WriteLine(ausgabeText);
            ausgabeText = string.Format("|{0}|", (rng.Next(0, 10) * Math.Pow(10, rng.Next(0, 10))));
            Console.WriteLine(ausgabeText);
            Console.WriteLine("**********************************************************");

            for (int i = 0; i < 10; i++)
            {
                ausgabeText = string.Format("Irgendeiein Text | {0,10:N0} |  Anderen Daten", (rng.Next(0, 10) * Math.Pow(10, rng.Next(0, 10))));
                // Positionierung bestimmt mit wievel Leerzeichen der Wert links oder rechts aufgefüllt werden muss
                // um die angegebene mindest Stellen anzahl zu erreichen
                // eine negative Zahl setzt es auf Linksbündig (rechts wird aufgefüllt)
                // eine positive Zahl setzt es auf Rechtsbündig (links wird aufgefüllt)
                Console.WriteLine(ausgabeText);
            }
            Console.WriteLine("**********************************************************");

            //Formatierung ohne string.Format
            // Syntax: {platzhalter,minStellen:formatierung}
            Console.WriteLine("Text mit formatierte Daten: {0,20:C3}", 5.345634);

            string dollarText = $"Noch ein Text mit Daten: {5.345634,20:C3}";
            Console.WriteLine(dollarText);
            Console.WriteLine("**********************************************************");

            // Beispieldaten fürs Beispiel.
            Kunde[] kunden = new Kunde[10];

            for (int i = 0; i < kunden.Length; i++)
            {
                kunden[i] = new Kunde();
                kunden[i].Name = $"Kunde {i}";
                kunden[i].Anrufe = rng.Next(9000, 11000);
                kunden[i].Größe = rng.NextDouble() * 2 + 0.5; // .NextDouble generiert eine Zufallszahl im Bereich 0 bis 1
                // um es in den Bereich zu bringen denn man will rechnet man: zz * Reichweite + Mindestwert
                kunden[i].Geburtsdatum = new DateTime(rng.Next(1970, 2020), rng.Next(1, 13), rng.Next(1, 29));
            }

            kunden[0].Name = "Anna Conda";
            kunden[1].Name = "Anna Bolika";
            kunden[2].Name = "Jane Doe";
            kunden[3].Name = "John Doe";
            kunden[4].Name = "Peter Irgendwer";



            //Beispiel Ausgabe von tabellarischen Kundendaten
            Console.WriteLine();
            Console.WriteLine("Name | Anruf | Größe | Geburtsdatum");
            for (int i = 0; i < kunden.Length; i++)
            {
                Console.WriteLine($"{kunden[i].Name}| {kunden[i].Anrufe} | {kunden[i].Größe}| {kunden[i].Geburtsdatum}");
            }
            Console.WriteLine();
            Console.WriteLine("**********************************************************");

            Console.WriteLine($"{"Name",-20} | {"Anrufe",-10} | {"Größe",-10} | {"GebDatum",-10}");
            for (int i = 0; i <kunden.Length; i++)
            {
                Console.WriteLine($"{kunden[i].Name,-20} | {kunden[i].Anrufe,10:N0} | {kunden[i].Größe,10:0.00' m'} | {kunden[i].Geburtsdatum,-10:d}");
                // DateTime hat seine eigenen Formatierungssymbole aber die Syntax ist die selbe wie bei den Zahlen
                // https://docs.microsoft.com/de-de/dotnet/standard/base-types/standard-date-and-time-format-strings
                // https://docs.microsoft.com/de-de/dotnet/standard/base-types/custom-date-and-time-format-strings
            }

            Console.ReadKey();
        }
    }
}
