using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_DELEGATE
{
    class Program
    {
        public delegate string Besucher(string Thema, string community, DateTime BesucherTime);

        class Webinare
        {
           private List<Besucher> onlinebesuchers;

           public Webinare ()
            {
                onlinebesuchers = new List<Besucher>();
            }

            public string Count (string place)
            {
                string community = "C# Developers chilling zone";
            }



        }









        static void Main(string[] args)
        {




        }
    }
}
