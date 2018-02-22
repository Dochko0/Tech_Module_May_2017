using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.FootballLeague
{
    public class Score
    {
        public decimal Points { get; set; }
        public decimal Goals { get; set; }
    }



    class Program
    {
        static void Main(string[] args)
        {
            var key = Regex.Escape(Console.ReadLine());


            var pattern = string.Format(@"^.*(?:{0})(?<team1>[a-zA-Z]*)(?:{0}).* .*(?:{0})(?<team2>[a-zA-Z]*)(?:{0}).* (?<team1Goals>\d+):(?<team2Goals>\d+).*$" , key);

            var matchRegex = new Regex(pattern);
            var matches = new Dictionary<string, Score>();

            while (true)
            {
                var line =Console.ReadLine();
                if (line == "final")
                {
                    break;
                }

                var matchMatch = matchRegex.Match(line);

                var team1Name = new string(matchMatch.Groups["team1"].Value.ToUpper().Reverse().ToArray());
                var team2Name = new string(matchMatch.Groups["team2"].Value.ToUpper().Reverse().ToArray());

                var team1Goals = int.Parse(matchMatch.Groups["team1Goals"].Value);
                var team2Goals = int.Parse(matchMatch.Groups["team2Goals"].Value);

                if (!matches.ContainsKey(team1Name))
                {
                    matches[team1Name] = new Score();
                }
                if (!matches.ContainsKey(team2Name))
                {
                    matches[team2Name] = new Score();
                }
                matches[team1Name].Goals += team1Goals;
                matches[team2Name].Goals += team2Goals;

                if (team1Goals>team2Goals)
                {
                    matches[team1Name].Points += 3;
                }
                else if (team1Goals < team2Goals)
                {
                    matches[team2Name].Points += 3;
                }
                else
                {
                    matches[team1Name].Points += 1;
                    matches[team2Name].Points += 1;
                }
            }
            var leagueStandings = matches.OrderByDescending(a => a.Value.Points).ThenBy(a => a.Key).ToArray();



            Console.WriteLine("League standings:");
            for (int i = 0; i < leagueStandings.Length; i++)
            {
                var currStandings = leagueStandings[i];
                var place = i + 1;
                var country = currStandings.Key;
                Console.WriteLine($"{place}. {country} {currStandings.Value.Points}");
            }

            var top3Goals = matches.OrderByDescending(a => a.Value.Goals).ThenBy(a => a.Key).Take(3).ToArray();

            Console.WriteLine("Top 3 scored goals:");
            foreach (var item in top3Goals)
            {
                var country = item.Key;
                var goals = item.Value.Goals;

                Console.WriteLine($"- {country} -> {goals}");
            }

        }
    }
}
