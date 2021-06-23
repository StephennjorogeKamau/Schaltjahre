using System;
using System.IO;
using System.Runtime.Serialization.Json;

namespace AufgabeJson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string pfad = @"c:\Test\AufgabeJson_3.json";
            Json3 k3;


            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Json3));

            using (FileStream fs = new FileStream(pfad, FileMode.Open))
            {
                k3 = (Json3)ser.ReadObject(fs);
                Console.WriteLine("Deserialiserung erfolgreich!");
            }
            Console.WriteLine();
           
            Console.WriteLine(k3);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
