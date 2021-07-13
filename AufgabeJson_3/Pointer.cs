using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AufgabeJson_3
{
    [DataContract]
    class Pointer
    {
        [DataMember]
        public string pointer;

        //Standard Konstruktor
        public Pointer() { }

        //Konstruktor
        public Pointer(string pointer)
        {
            this.pointer = pointer;
        }


        public override string ToString()
        {
            return $"Pointer: {pointer} ";
        }
    }
}
