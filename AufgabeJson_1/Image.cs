using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AufgabeJson_1
{
    [DataContract]
    class Image
    {
        [DataMember]
        public string src;
        [DataMember]
        public string name;
        [DataMember]
        public int hOffset;
        [DataMember]
        public int vOffset;
        [DataMember]
        public string alignment;

       
        //Methoden
        public override string ToString()
        {
            return $"src: {src}\nname: {name}\nhOffset: {hOffset}\nvOffset: {vOffset}\nalignment: {alignment}";
        }
    }
}
