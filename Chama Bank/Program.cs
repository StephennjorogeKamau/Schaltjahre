using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chama_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creat account Array
            Accounts Account1 = new Accounts(21000, "Kamau", 50,-100, 1234);
            Console.WriteLine();
            bool check = true;
            do
            {
                bool IsRunning = true;
                //User Pin Eingaben
                Console.WriteLine("Bitte geben Sie Ihre Pin ein: ");
                int UserPininput = Convert.ToInt32(Console.ReadLine());

                if (UserPininput == Account1.Getpin())
                {
                    while (IsRunning)
                    {
                        //kunde Abfrage Menü
                        Console.WriteLine("Willkommen bei Chama Bank");
                        Console.WriteLine();
                        Console.WriteLine("Wählen Sie den Folgenden Punkten aus");
                        Console.WriteLine("1. Kontostand Abfrage");
                        Console.WriteLine("2. Geldeinzahlen");
                        Console.WriteLine("3. Geldauszahlen");
                        Console.WriteLine("4. Pin Ändern");
                        Console.WriteLine();

                        //Userinput
                        int Userinput = Convert.ToInt32(Console.ReadLine());

                        //Switch implementieren.
                        switch (Userinput)
                        {
                            case 1:
                                //Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine($"Kontoinhaber: {Account1.GetOwner()} \nKontonummer: {Account1.GetAccountNumber()} \nKontostand: {Account1.GetAccounBalance()}");
                                Console.WriteLine("Belibige Taste drucken");
                                Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine($"Einzahlung:\nWie viele Geld möchte Sie einzahlen?");
                                int userinputEinzahlung = Convert.ToInt32(Console.ReadLine());
                                Account1.GeldEinzahlen(userinputEinzahlung);
                                Console.WriteLine($"Einzahlung von {userinputEinzahlung} erfolgreich! ");
                                Console.WriteLine("Belibige Taste drucken");
                                Console.ReadLine();

                                break;
                            case 3:
                                Console.WriteLine($"Auzahlung:\nWie viele Geld möchte Sie Auszahlen ?");
                                int userinputAuszahlung = Convert.ToInt32(Console.ReadLine());
                                Account1.GeldAuszahlen(userinputAuszahlung);
                                Console.WriteLine($"Auszahlung von {userinputAuszahlung} erfolgreich! ");
                                Console.WriteLine("Belibige Taste drucken");
                                Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("Möchten Sie Ihre Pin Ändern?\nj/n");
                                string Antwort = Console.ReadLine();
                                

                                if (Antwort == "j")
                                {
                                    Console.WriteLine("Bitte NEUE Pin eigaben!");
                                    int userInputNewPin = Convert.ToInt32(Console.ReadLine());
                                    Account1.newPin(userInputNewPin);
                                    Console.WriteLine($"Pin geändert\nIhre Neu Pin ist {userInputNewPin}");
                                    //Console.WriteLine("Bitte geben Sie Ihre Neu Pin ein: ");
                                    Console.WriteLine("Belibige Taste drucken");
                                    Console.ReadLine();
                                    if(Account1.Getpin()== userInputNewPin)
                {
                                        IsRunning = false;
                                    }
                                }
                                break;

                            default:
                                IsRunning = false;
                                break;
                        }
                    }
                }
                else
                {
                    //Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sie haben das falsche Pin eingegeben ");
                    Console.WriteLine("Zu erneut, Bitte ENTER Taste Drücken! ");
                    Console.ReadLine();
                }
                //Console.WriteLine("Bitte Drücken ENTER Taste");
            } while (check);

            
        }
    }
}
