using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.RoliTheCoder
{
    class Event
    {
        public string Name { get; set; }
        public List<string> Particians { get; set; }

    }



    class Program
    {
        static void Main(string[] args)
        {
            var eventsRegex = new Regex(@"(?<id>\d+)\s+#(?<eventName>\w+)\s*(?<participants>(?:@[A-Za-z0-9'\-]+\s*)*)");

            var events = new Dictionary<int, Event>();

            while (true)
            {
                var line = Console.ReadLine();
                if (line == "Time for Code")
                {
                    break;
                }
                var Match = eventsRegex.Match(line);
                if (!Match.Success)
                {
                    continue;
                }


                var id = int.Parse(Match.Groups["id"].Value);
                var eventName = Match.Groups["eventName"].Value;
                var participantsStr = Match.Groups["participants"].Value;
                var participants = new List<string>();

                if (participantsStr.Length>0)
                {
                    participants.AddRange(participantsStr.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                }

                if (!events.ContainsKey(id))
                {
                    var even = new Event
                    {
                        Name = eventName,
                        Particians = participants
                    };
                    events[id] = even;
                }

                if (events[id].Name == eventName)
                {
                    events[id].Particians.AddRange(participants);
                }
            }

            foreach (var item in events)
            {
                item.Value.Particians = item.
                    Value.
                    Particians.
                    Distinct().
                    OrderBy(a=>a).
                    ToList();
            }

            var sortedEvents = events
                .OrderByDescending(a => a.Value.Particians.Count)
                .ThenBy(a=>a.Value.Name)
                .Select(a=>a.Value)
                .ToArray();

            foreach (var sortedEvent in sortedEvents)
            {
                Console.WriteLine($"{sortedEvent.Name} - {sortedEvent.Particians.Count}");

                foreach (var participant in sortedEvent.Particians)
                {
                    Console.WriteLine(participant);
                }

            }

        }
    }
}
