using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AufgabeJson_2
{
    [DataContract]
    class buchs
    {
        //Felder
        [DataMember]
        public string id;
        [DataMember]
        public string language;
        [DataMember]
        public string edition;
        [DataMember]
        public string author;

        //Konstruktor
        public buchs(string id, string language, string edition, string author)
        {
            this.id = id;
            this.language = language;
            this.edition = edition;
            this.author = author;
        }

        //Standard Konstruktor
        public buchs() { }

        //Methoden
        public override string ToString()
        {
            return $"id: {id}\nlanguage: {language}\nedition: {edition}\nauthor: {author}";

        }
    }
}
