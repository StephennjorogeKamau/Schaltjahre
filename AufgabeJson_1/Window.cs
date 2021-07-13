using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AufgabeJson_1
{
   [DataContract]
    class Window
    {
        //Felder
        [DataMember]
        public string title;
        [DataMember]
        public string name;
        [DataMember]
        public int width;
        [DataMember]
        public int height;

        public override string ToString()
        {
            return $"title: {title}\nname: {name}\nwidth: {width}\nheight: {height}";
        }

    }
}
