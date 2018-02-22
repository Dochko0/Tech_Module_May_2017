using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var phrases = ListOfPhrases();
            var eventIndex = ListOfEventIndex();
            var autors = ListOfAutors();
            var towns = ListOfTowns();

            Random rnd = new Random();

            string phrasesForPrint = phrases[rnd.Next(phrases.Count)];
            string eventIndexForPrint = eventIndex[rnd.Next(eventIndex.Count)];
            string autorsForPrint = autors[rnd.Next(autors.Count)];
            string townsForPrint = towns[rnd.Next(towns.Count)];

            Console.WriteLine($"{phrasesForPrint} {eventIndexForPrint} {autorsForPrint} – {townsForPrint}.");
        }

        public static List<string> ListOfTowns()
        {
            List<string> allTowns = new List<string>()
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse" 
            };
            return allTowns;
        }

        public static List<string> ListOfAutors()
        {
            List<string> allAutors = new List<string>()
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };
            return allAutors;
        }

        public static List<string> ListOfEventIndex()
        {
            List<string> allEventIndex = new List<string>()
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };
            return allEventIndex;
        }

        public static List<string> ListOfPhrases()
        {
            List<string> allPhrases = new List<string>()
            {
                 "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            return allPhrases;
        }
    }
}
