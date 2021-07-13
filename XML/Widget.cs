using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XML
{
    [XmlRoot("widget")]

    public class Widget
    {
        public string debug;
        public Window window;
        public Image image;
        public Text text;

        public override string ToString()
        {
            return $"{debug}\n{window}\n{image}\n{text}";
        }
    }
}
