using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XML
{
    class Program
    {
        static void Main(string[] args)
        {
            string pfad = @"c:\Test\AufgabeXML3.xml";
            Widget w2;

            XmlSerializer ser = new XmlSerializer(typeof (Widget));

            using (StreamReader sr = new StreamReader(pfad))
            {
                w2 = (Widget)ser.Deserialize(sr);
                Console.WriteLine("Erfolgreich");
            }

            Console.WriteLine();
            Console.WriteLine(w2);

        }
    }
}
