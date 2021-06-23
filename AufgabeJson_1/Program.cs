using System;
using System.IO;
using System.Runtime.Serialization.Json;

namespace AufgabeJson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe Json
            string aufgabe = @"c:\Test\AufgabeJson_1.json";
            Alleklasse k1;

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Alleklasse));

            using (FileStream fs = new FileStream(aufgabe, FileMode.Open))
            {
                k1 = (Alleklasse)ser.ReadObject(fs);
                Console.WriteLine("Deserialiserung erfolgreich!");
            }
            Console.WriteLine();
            Console.WriteLine(k1);

            Console.ReadLine();
        }        
    }
}
