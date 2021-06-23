using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AufgabeJson_1
{
    [DataContract]
    class Text
    {
        [DataMember]
        public string data;
        [DataMember]
        public int size;
        [DataMember]
        public string style;
        [DataMember]
        public string name;
        [DataMember]
        public int hOffset;
        [DataMember]
        public int vOffset;
        [DataMember]
        public string alignment;
        [DataMember]
        public string onMouseUp;

        //Methoden
        public override string ToString()
        {
            return $"data: {data}\nsize: {size}\nstyle: {style}\nhOffset: {hOffset}\nvOffset: {vOffset}\nalignment: {alignment}\n{onMouseUp}";
        }
    }
}
