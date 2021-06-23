using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Json_Serialisierung
{
    class Program
    {
        static void Main(string[] args)
        {
            string pfad = @"c:\Test\SerJson.json";
            Person p1 = new Person("Steve0", 27, new Adresse("Malibustrasse", "1213", "79165", "Karibian"));
            Person p2;

            //serialisierer
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Person));

            //Data schreiben - Serialierung
            using (FileStream fs = new FileStream(pfad, FileMode.Create))
            {
                ser.WriteObject(fs, p1);
                Console.WriteLine("Serialisierung erfolgreich!");
            }
            //Data auslesen - Deserialierung
            using (FileStream fs = new FileStream(pfad, FileMode.Open))
            {
                p1 = (Person)ser.ReadObject(fs);
                Console.WriteLine("Deserialisierung erfolgreich!");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
