using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {



            var input = Console.ReadLine().Split(':').ToArray();
            int sum = 0;
            int sumForPlayer = 0;
            //string firstClean = "";
            Dictionary <string, int> score = new Dictionary<string, int>();

            Dictionary<string, string> cleanCard = new Dictionary<string, string>();


            while (input[0]!="JOKER")
            {
                var name = input[0];
                
                var secondPart = input[1];
                var cards = secondPart.Split(',').Distinct().ToList();
                //List<string> rem = new List<string>();
                //if (cleanCard.ContainsKey(name))
                //{
                //    foreach (var item in cards)
                //    {
                //        if (cleanCard.ContainsValue(item))
                //        {
                //            rem.Add(item);
                //        }
                //    }
                //    foreach (var r in rem)
                //    {
                //        cards.Remove(r);
                //    }                  
                //}
               
                foreach (var c in cards)
                {
                    var chars = c.ToCharArray();
                    int a = 0;
                    int b = 0;
                    switch (chars[1])
                    {
                        case '1': a = 10; break;
                        case '2': a = 2; break;
                        case '3': a = 3; break;
                        case '4': a = 4; break;
                        case '5': a = 5; break;
                        case '6': a = 6; break;
                        case '7': a = 7; break;
                        case '8': a = 8; break;
                        case '9': a = 9; break;
                        case 'J': a = 11; break;
                        case 'Q': a = 12; break;
                        case 'K': a = 13; break;
                        case 'A': a = 14; break;
                        default: break;
                    }
 
                    switch (chars[2])
                    {
                        case 'S': b = 4; break;
                        case 'H': b = 3; break;
                        case 'D': b = 2; break;
                        case 'C': b = 1; break;
                        default: break;
                    }
                    if (chars.Length==4)
                    {
                        switch (chars[3])
                        {
                            case 'S': b = 4; break;
                            case 'H': b = 3; break;
                            case 'D': b = 2; break;
                            case 'C': b = 1; break;
                            default: break;
                        }
                    }
                    
                    sum = sum + a * b;
                }
                //string clean = String.Join("", cards);

                if (score.ContainsKey(name))
                {                
                        score.TryGetValue(name, out sumForPlayer);
                        score[name] = sum + sumForPlayer;
                    //cleanCard[name] = firstClean + clean;
                }
                else
                {
                    sumForPlayer = sum;
                    //firstClean = clean;
                    score[name] = sumForPlayer;
                    //cleanCard[name] = firstClean;
                }
                input = Console.ReadLine().Split(':').ToArray();
                sum = 0;
            }
            foreach (var item in score)
            {
                Console.WriteLine($"{item.Key}: {item.Value} ");
            }



            //Console.WriteLine(name);
            //Console.WriteLine(string.Join(" \n", cards));
            



        }
    }
}
