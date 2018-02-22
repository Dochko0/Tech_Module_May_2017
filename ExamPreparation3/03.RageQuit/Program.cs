using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToUpper();

            //-----Ако последната цифра не е число-----

            //if (!char.IsDigit(input.LastOrDefault()))
            //{
            //    input+=1;
            //}

            //----------------------------------------

            var matches = Regex.Matches(input, @"(\D+)(\d+)");
            StringBuilder result = new StringBuilder();
            foreach (Match match in matches)
            {
                var text = match.Groups[1].Value;
                var count = int.Parse(match.Groups[2].Value);
                for (int i = 0; i < count; i++)
                {
                    result.Append(text);
                }
            }

            //Console.WriteLine("Unique symbols used: {0}", result.ToString().Distinct().Count());
            //Console.WriteLine(result);


            //--------------------------------------------
            //Втори вариант на принтиране

            var output = result.ToString();
            var charCounts = new Dictionary<char, int>();

            foreach (var ch in output)
            {
                charCounts[ch] = 0;
            }
            foreach (var ch in output)
            {
                charCounts[ch]++;
            }
            Console.WriteLine("Unique symbols used: {0}", charCounts.Count);
            Console.WriteLine(result);




        }
    }
}

