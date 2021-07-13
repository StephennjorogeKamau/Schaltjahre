using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace AufgabeJson_4
{
    [DataContract]
    class Alleklasse
    {
        [DataMember]
        public int reNr;
        [DataMember]
        public DateTime reDat;
        [DataMember]
        public Kunde kunde;
        [DataMember]
        public List<Artikel> artikels;

        //Konstruktor
        public Alleklasse(int reNr, DateTime reDat, Kunde kunde, List<Artikel> artikels)
        {
            this.reNr = reNr;
            this.reDat = reDat;
            this.kunde = kunde;
            this.artikels = artikels;
        }

        //Standard Konstruktor
        public Alleklasse() { }

        //Methoden
        public override string ToString()
        {
            int counter = 1;
            string art = $"Rechungsnummer:\t{reNr}\nDatum:\t\t{reDat.ToShortDateString()}\n\n{kunde}\n\n"; ;

            foreach (Artikel item in artikels)
            {
                if (counter < 10)
                    art += $"0{counter++}.{item}\n\n";
                else
                    art += $"{counter++}.{item}\n\n";
            }

            return art;
        }
        public static void DatenAnlage(string pfad)
        {
            Alleklasse alle = new Alleklasse(1234, new DateTime(2021, 4, 12), new Kunde("Karl", 57, 1.76f, false), new List<Artikel>());
            alle.artikels.Add(new Artikel("A38", "Passierschein A38", "Das Amt", 1.19f));
            alle.artikels.Add(new Artikel("A39", "Passierschein A39", "Das andere Amt", 2.19f));
            alle.artikels.Add(new Artikel("B38", "Passierschein B38", "Das ganz andere Amt", 3.19f));

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(List<Alleklasse>));

            using (FileStream fs = new FileStream(pfad, FileMode.Create))
            {
                ser.WriteObject(fs, alle);
            }

        }
    }
}
