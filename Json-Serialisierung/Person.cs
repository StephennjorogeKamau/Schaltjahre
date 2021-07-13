using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Json_Serialisierung
{
    [DataContract]
    class Person
    {
        //Felder
        [DataMember]
        internal string name;
        [DataMember]
        public int alter;
        [DataMember]
        public Adresse adr;

        //Konstuktor
        public Person(string name, int alter, Adresse adr)
        {
            this.name = name;
            this.alter = alter;
            this.adr = adr;
        }
        //Standard Konstuktor
        public Person() { }

        //Methoden
        public override string ToString()
        {
            return $" Name: {name}\nAlter: {alter}";
        }

       
    }
}
