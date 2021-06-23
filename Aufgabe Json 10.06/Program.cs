using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Aufgabe_Json_10._06
{
    class Transaction
    {
        public double amount { get; set; }
        public string Intendeduse { get; set; }
        public string receiver { get; set; }
        public string sender { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var transaciton = new Transaction
            {
                amount = 150.25,
                Intendeduse = "Pay Electricity Bill",
                receiver = "Enbw",
                sender = "Kamau Stephen",
            };

            //als Json speichern / Schreiben

            var transjson = jsonSeriakizer



        }
    }
}
