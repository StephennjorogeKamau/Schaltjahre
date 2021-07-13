using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Json_Serialisierung
{
    [DataContract]
    class Adresse
    {
        //Felder
        [DataMember]
        public string strasse;
        [DataMember]
        public string hausNr;
        [DataMember]
        public string plz;
        [DataMember]
        public string ort;

        public Adresse(string strasse, string hausNr, string plz, string ort)
        {
            this.strasse = strasse;
            this.hausNr = hausNr;
            this.plz = plz;
            this.ort = ort;
        }
        //Standard konstruktor
        public Adresse() { }

        public override string ToString()
        {
            return $"Adresse:\n{strasse} {hausNr}\n{plz} {ort}";
        }


    }
}
