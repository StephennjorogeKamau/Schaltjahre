using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AufgabeJson_3
{
    [DataContract]
    class Fehler
    {
        //Felder
        [DataMember]
        public string status;
        [DataMember]
        public Pointer source;
        [DataMember]
        public string detail;
        [DataMember]
        public string title;

        //Konstruktor
        public Fehler(string status, Pointer source, string detail, string title )
        {
            this.status = status;
            this.source = source;
            this.detail = detail;
            this.title = title;
        }

        //Standard Konstruktor
        public Fehler() { }

        //Methoden
        public override string ToString()
        {
            return $"status: {status}\nsource: {source}\ntitle: {title}\ndetail: {detail}";
            
        }
    }
}
