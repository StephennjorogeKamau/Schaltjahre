using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AufgabeJson_2
{
    [DataContract]
    class alleklasse
    {
        //Liste von Buchs
        [DataMember]
        public List<buchs> book;

        //Konstruktor
        public alleklasse(List<buchs> book)
        {
            this.book = book;
        }

        //Standard Konstruktor
        public alleklasse() { }
        


        //Methoden
        public override string ToString()
        {
            string bks = "";
            foreach(buchs item in book)
            {
                bks += item.ToString() + "\n";
            }
            return bks;
        }

    }
}
