using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XML
{
    public class Window
    {
        [XmlAttribute]
        public string title;
        public string name;
        public int width;
        public int height;

        public override string ToString()
        {
            return $"{title}\n{name}\n{width}\n{height}";
        }

    }
}
