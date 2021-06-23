using System;
using System.IO;
using System.Runtime.Serialization.Json;

namespace AufgabeJson_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Aufgabe Json_2 Auslessen
            string pfad = @"c:\Test\AufgabeJson_2.json";
            alleklasse k2;
           
            //Json Serializer
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(alleklasse));

            //File pfad aufrufen und öffnen
            using (FileStream fs = new FileStream(pfad, FileMode.Open))
            {
                k2 = (alleklasse)ser.ReadObject(fs);
                Console.WriteLine("Deserialiserung erfolgreich!");
            }
            Console.WriteLine();

            //Liste Ausdrucken
            
            Console.WriteLine();
            Console.WriteLine(k2);
            Console.ReadLine();


        }
    }
}

