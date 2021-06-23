using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AufgabeJson_4
{
    [DataContract]
    class Kunde
    {
        //Felder
        [DataMember]
        public string name;
        [DataMember]
        public int alter;
        [DataMember]
        public float groesse;
        [DataMember]
        public bool rechtHaender;

        //Standard Konstruktor
        public Kunde() { }

        //Konstruktor
        public Kunde(string name, int alter, float groesse, bool rechtHaender)
        {
            this.name = name;
            this.alter = alter;
            this.groesse = groesse;
            this.rechtHaender = rechtHaender;
        }

        //Methoden
        public override string ToString()
        {
            string str = $"name: {name}\nAlter: {alter}\ngroess: {groesse}\nrechtHander: {rechtHaender}";
            if (rechtHaender)
                str += "Ja";
            else
                str += "Nein";
            return str;
        }



    }
}
