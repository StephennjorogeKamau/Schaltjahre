using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AufgabeJson_4
{
    [DataContract]
    class Artikel
    {
        //Felder
        [DataMember]
        public string id;
        [DataMember]
        public string beschreibung;
        [DataMember]
        public string hersteller;
        [DataMember]
        public float preis;

        //Standard Konstruktor
        public Artikel() { }

        //konstruktor
        public Artikel(string id, string beschreibung, string hersteller,  float preis)
        {
            this.id = id;
            this.beschreibung = beschreibung;
            this.hersteller = hersteller;
            this.preis = preis;
        }

        //Methoden
        public override string ToString()
        {
            return $"ID: {id}\nBeschreibung: {beschreibung}\nHersteller: {hersteller}\nPreis: {preis}";
        }
    }
}
