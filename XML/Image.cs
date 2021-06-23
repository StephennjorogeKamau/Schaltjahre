using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XML
{
    public class Image
    {
        [XmlAttribute]
        public string src;
        [XmlAttribute]
        public int name;
        public int hOffset;
        public int vOffset;
        public string alignment;

        public override string ToString()
        {
            return $"{src}\n{name}\n{hOffset}\n{vOffset}\n{alignment}";
        }
    }
}
