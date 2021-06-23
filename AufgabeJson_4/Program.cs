using System;
using System.IO;
using System.Runtime.Serialization.Json;




namespace AufgabeJson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string pfad = @"c:\Test\AufgabeJson_4.json";
            Alleklasse k4;

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Alleklasse));

            using (FileStream f4 = new FileStream(pfad, FileMode.Open))
            {
                k4 = (Alleklasse)ser.ReadObject(f4);
                System.Console.WriteLine("Deserialiserung erfolgreich!");
            }
            Console.WriteLine();
            Console.WriteLine(k4);
            Console.WriteLine();

            Console.ReadLine();


        }
    }
}
