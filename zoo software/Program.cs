using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoo_software
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variablen
            string Eingabe, Eingabe2;
            bool check;
            DateTime dt = DateTime.Now;
            //Eingbe Auswahlen
            while (true)
            {
                do
                {
                    check = false;
                    Console.Clear();
                    Console.WriteLine(dt + " Wilkomen bei Zoo Karlsruhe");
                    Console.WriteLine();
                    Console.WriteLine(" (1) Löwe");
                    Console.WriteLine(" (2) Affen");
                    Console.WriteLine(" (3) Elephante");
                    Console.WriteLine(" (4) Schlange");
                    Console.WriteLine(" (5) Gorilla");
                    Console.WriteLine();
                    Console.WriteLine("Bitte wählen Sie Ihre Tiere aus: ");
                    Eingabe = Console.ReadLine();
                    Console.WriteLine("Sie haben " + Eingabe + " gewählt");
                    Console.WriteLine();
                    if (Eingabe.ToUpper() == "EXIT")
                        Environment.Exit(0);
                    if (Eingabe == "1" ^ Eingabe == "2" ^ Eingabe == "3" ^ Eingabe == "4" ^ Eingabe == "5")
                    {
                        check = true;
                    }
                    else
                    {
                        Console.WriteLine("Bitte nur 1 - 5 Auswahlen");
                        Console.WriteLine("Exit zu beenden");
                        Console.WriteLine("Beliebiger Taste Drucken");
                        Console.ReadKey();
                    }

                } while (!check);

                //Menü
                do
                {
                    check = true;
                    Console.WriteLine("(1) Beschreibung des Tieres");
                    Console.WriteLine("(2) Wegbeschriebung zum Gehege");
                    Console.WriteLine();
                    Console.WriteLine("Bitte Auswahlen: ");
                    Console.WriteLine();
                    Eingabe2 = Console.ReadLine();
                    if (Eingabe2.ToUpper()== "EXIT")
                        Environment.Exit(0);

                    //if (Eingabe2 == "1" ^ Eingabe2 == "2")
                    //{
                    //    check = true;
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Bitte nur 1 oder 2 Auswählen");
                    //    Console.WriteLine();
                    //    Console.WriteLine("Beliebiger Taste Drucken");
                    //    Console.ReadKey();
                    //}        
                } while (false);

                switch (Eingabe)
                {
                    case "1":
                        Löwe(Eingabe2);
                        break;

                    case "2":
                        Affen(Eingabe2);
                        break;

                    case "3":
                        Elephante(Eingabe2);
                        break;

                    case "4":
                        Schlange(Eingabe2);
                        break;

                    case "5":
                        Gorilla(Eingabe2);
                        break;
                    default:
                        Console.WriteLine("Bitte wählen Sie Ziffer ein.");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Beliebiger Taste Drucken");
                Console.WriteLine();
                Console.WriteLine("Exit zu beenden");
                Console.ReadKey();

            }



        }
        static void Löwe(string schreibung)
        {
            Console.Clear();
            if (schreibung == "1")
                Console.WriteLine("Der Löwe ist nach dem Tiger die zweitgrößte Art aus der Familie der Katzen. Er ist heute nur noch in Teilen Afrikas südlich der Sahara sowie im indischen Bundesstaat Gujarat beheimatet; in Afrika ist er das größte Landraubtier.");
            else if (schreibung == "2")
                Console.WriteLine(" Es befinden sich, Gerade aus, zweite Abweigung recht");
            else
                Console.WriteLine("Sie haben Löwe gewahlt. Welche Beschriebung wünscht Ihr?");
        }

        static void Affen(string schreibung)
        {
            Console.Clear();
            if (schreibung == "1")
                Console.WriteLine("Affen sind mit Ausnahme der Nachtaffen immer tagaktiv. Sie haben verschiedene Fortbewegungsarten entwickelt, neben dem zweibeinigen Gehen (Mensch) und dem vierbeinigen Gehen findet sich auch das senkrechte Klettern und Springen und das Schwinghangeln.");
            else if (schreibung == "2")
                Console.WriteLine(" Es befinden sich, drausen an der Terrase.");
            else
                Console.WriteLine("Sie haben Affen gewahlt.Welche Beschriebung wünscht Ihr? ");
        }
        static void Elephante(string schreibung)
        {
            Console.Clear();
            if (schreibung == "1")
                Console.WriteLine("Elefanten sind soziale Tiere, die in Familiengruppen aus weiblichen Individuen und deren Nachwuchs leben. Sie durchstreifen mehr oder weniger große Aktionsräume auf der Suche nach Nahrung.");
            else if (schreibung == "2")
                Console.WriteLine(" Es befinden sich, drausen an der Ausgang.");
            else
                Console.WriteLine("Sie haben Elephante gewahlt.Welche Beschriebung wünscht Ihr? ");
        }

        static void Schlange(string schreibung)
        {
            Console.Clear();
            if (schreibung == "1")
                Console.WriteLine("Schlangenhaut besteht aus drei Schichten: der Epidermis (Oberhaut), der Dermis (Lederhaut) und der Subdermis (Unterhaut). Alle Schichten erfüllen verschiedene Funktionen.");
            else if (schreibung == "2")
                Console.WriteLine(" Es befinden sich, Gerade an der Dritte Abweigung Links.");
            else
                Console.WriteLine("Sie haben Schlangen gewahlt.Welche Beschriebung wünscht Ihr? ");
        }

        static void Gorilla(string schreibung)
        {
            Console.Clear();
            if (schreibung == "1")
                Console.WriteLine("Gorillas können sowohl auf dem Boden als auch in den Bäumen nach Nahrung suchen. Am Boden bewegen sie sich wie die Schimpansen in einem vierfüßigen Knöchelgang fort, das heißt, sie stützen sich auf die zweiten und dritten Fingerglieder. Selten gehen sie auch allein auf den Beinen, dabei legen sie jedoch nur kurze Distanzen zurück.");
            else if (schreibung == "2")
                Console.WriteLine(" Es befinden sich, drausen an der zweite Abweigung Links.");
            else
                Console.WriteLine("Sie haben Gorilla gewahlt.Welche Beschriebung wünscht Ihr? ");
        }
        static void Exit()
        {
            Console.WriteLine("Exit: ja / nein ");

        }
    }

}
