using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AufgabeJson_3
{
    [DataContract]
    class Json3
    {
        //Liste Generiren
        [DataMember]
        List<Fehler> errors;

        //Standard Konstruktor
        public Json3() { }

        //Konstruktor
        public Json3(List<Fehler> errors)
        {
            this.errors = errors;
        }

        //Methoden
        public override string ToString()
        {
            string err = "";
            foreach (Fehler item in errors)
            {
                err += item.ToString() + "\n\n";
            }
            return err;
        }

    }
}
