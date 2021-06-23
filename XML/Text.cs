using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XML
{
    public class Text
    {
        [XmlAttribute]
        public string data;
        [XmlAttribute]
        public int size;
        [XmlAttribute]
        public string style;
        public int hOffset;
        public int vOffset;
        public string alignment;
        public string onMouseUp;

        public override string ToString()
        {
            return $"{data}\n{size}\n{style}\n{hOffset}\n{vOffset}\n{alignment}\n{onMouseUp}";
        }
    }
}
