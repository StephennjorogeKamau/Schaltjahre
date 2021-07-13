using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Season
{
    Spring = 1,
    Summer,
    Autumn,
    Winter
}

enum Language
{
    English,
    Germany
}

namespace Enumeration
{
    class Program
    {
        static string[] GetTraslation(Language language)
        {
            string[] translation = new string[20];

            switch (language)
            {
                case Language.English:
                    translation[(int)Season.Spring] = "Spring";
                    translation[(int)Season.Summer] = "Summer";
                    translation[(int)Season.Autumn] = "Autumn";
                    translation[(int)Season.Winter] = "Winter";
                    break;
                case Language.Germany:
                    translation[(int)Season.Spring] = "Frühling";
                    translation[(int)Season.Autumn] = "Herbst";
                    translation[(int)Season.Summer] = "Sommer";
                    translation[(int)Season.Winter] = "Winter";
                    break;
                default:
                    break;
            }


            return translation;

        }
        static void Main(string[] args)
        {

            string[] translation = GetTraslation(Language.Germany);

            Console.WriteLine("Jahreszeit wählen:");
            foreach (Season season in (Season[])Enum.GetValues(typeof(Season)))
            {
                int seasonOptionValue = (int)season;
                string seasonOptionValueTranslation = translation[seasonOptionValue];
                Console.WriteLine($"{seasonOptionValue}) {seasonOptionValueTranslation}");
            }
            string consoleInput = Console.ReadLine();
            int consoleInputInt = Convert.ToInt32(consoleInput);
            Season seasonOption = (Season)consoleInputInt;

            switch (seasonOption)
            {
                case Season.Spring:
                    Console.WriteLine("Es ist Frühling!");
                    break;
                case Season.Summer:
                    Console.WriteLine("Es ist Sommer!");
                    break;
                case Season.Autumn:
                    Console.WriteLine("Es ist Herbst!");
                    break;
                case Season.Winter:
                    Console.WriteLine("Es ist Winter!");
                    break;
                default:
                    break;
            }
            string seasonOptionTranslated = translation[(int)seasonOption];

            Console.WriteLine($"Auswahl: {seasonOptionTranslated}");
            Console.ReadLine();
        }
    }
}
