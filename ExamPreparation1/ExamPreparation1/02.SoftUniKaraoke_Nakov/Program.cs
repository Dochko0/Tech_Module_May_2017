using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.SoftUniKaraoke_Nakov
{
    class Program
    {
        static void Main(string[] args)
        {
            var allPlayers = Regex.Split(Console.ReadLine(), @"\s*,\s*");
            var allSongs = Console.ReadLine().Split(',').Select(s=>s.Trim()).ToArray();

            var awardsByPlayer = new Dictionary<string, List<string>>();
            foreach (var p in allPlayers)
            {
                awardsByPlayer[p] = new List<string>();
            }

            while (true)
            {
                var command = Console.ReadLine();
                if (command=="dawn")
                {
                    break;
                }
                var tokens = Regex.Split(command, @"\s*,\s*");

                var player = tokens[0];
                var song = tokens[1];
                var award = tokens[2];

                if (allPlayers.Contains(player) && allSongs.Contains(song))
                {
                    awardsByPlayer[player].Add(award);
                }

            }

            //var personsWithAwards = awardsByPlayer.OrderByDescending(item => item.Value.Count).ThenBy(item=>item.Key);

            var personWithAwardsSecond = awardsByPlayer.Select(item => new
            {
                playerName = item.Key,
                awards = item.Value.Distinct().OrderBy(a=>a),
                awardsCount = item.Value.Distinct().Count()
            }).OrderByDescending(p=>p.awardsCount).
            ThenBy(p=>p.playerName).
            Where(p=>p.awardsCount>0).
            
            ToArray();



            foreach (var p in personWithAwardsSecond)
            {
                Console.WriteLine($"{p.playerName}: {p.awardsCount} awards");
                foreach (var aw in p.awards)
                {
                    Console.WriteLine($"--{aw}");
                }
            }

            if (personWithAwardsSecond.Length == 0)
            {
                Console.WriteLine("No awards");
            }


        }
    }
}
