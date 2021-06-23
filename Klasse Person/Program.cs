using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasse_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] people = new int[5];
            Person person1 = new Person();
            person1.Nachname = "Doe";
            person1.Vorname = "John";
            person1.Geburtsjahr = 1990;
            person1.Geschlecht = 'M';
            person1.Körpergewicht = 75.5;
            person1.Grouss = 182;
            Console.WriteLine("Person 1");
            Console.WriteLine(
               $"Nachname: {person1.Nachname} \n" +
            $"Vorname: {person1.Vorname} \n" +
            $"Geburtsjahr: {person1.Geburtsjahr} \n" +
            $"Geschlecht: {person1.Geschlecht} \n" +
            $"Körpergewicht (kg): {person1.Körpergewicht} \n" +
            $"Grouss (cm): {person1.Grouss}"
                );
            Console.WriteLine(" BMI ");
            //Console.WriteLine(person1.Linda());
            Console.WriteLine(person1.Bmi());
            Console.WriteLine("kcal_bedarf");
            Console.WriteLine(person1.Kcal());
            Console.ReadKey();
        }
    }
}
