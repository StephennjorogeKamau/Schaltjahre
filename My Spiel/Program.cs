using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Spiel
{
    class Program
    {

        static void Main(string[] args)
        {

            Player Benutzer1 = new Player(100,150,100,150);

            bool IsRunning = true;
            while (IsRunning)
            {
                Console.WriteLine($"{Benutzer1.GetLife()} / {Benutzer1.GetMana()}");

                if (Benutzer1.IsDefeated())
                {
                    Console.WriteLine("Game Over!");
                }

                 Console.WriteLine("Achtung! Aktion Wählen");
                 Console.WriteLine("1. Angreifen");
                Console.WriteLine("2. Heilen.");
                Console.WriteLine("3. Zaubern.");
                Console.WriteLine("4. Mana regenerieren");
                Console.WriteLine("0. Beenden");

                int Aktion =Convert.ToInt32(Console.ReadLine()); 
                Console.WriteLine();

                //methode anrufen 

                switch (Aktion)
                {
                    case 1:
                        Benutzer1.Attack();
                        break;
                    case 2:
                        Benutzer1.Heal();
                        break;
                    case 3:
                        Benutzer1.Spell();
                        break;
                    case 4:
                        Benutzer1.RegenerateMana();
                        break;
                    case 0:
                        IsRunning = false;
                        Console.WriteLine(" Aufwiedersehen! \n  Belibiegen Taste drucken");
                        break;
                }
            }

            Console.ReadLine();
        }
        
      
    } 
    
}
