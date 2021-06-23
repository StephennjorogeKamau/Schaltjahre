using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AufgabeJson_1
{
    [DataContract]
    class Alleklasse
    {
        [DataMember]
        public string debug;
        [DataMember]
        public Window window;
        [DataMember]
        public Image image;
        [DataMember]
        public Text text;

        //Methoden
        public override string ToString()
        {
            return $"Debug: {debug}\n{window}\n{image}\n{text}";
        }


    }
}
