using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.RoliTheCoder1
{
    class RoliTheCoder1
    {
        static void Main(string[] args)
        {
            var eventsRegex = 
                new Regex(@"(?<id>\d+)\s+#(?<eventName>\w+)\s*(?<participiant>(?:@[a-zA-z0-9'-]+\s*)*)");
            var events = new Dictionary<int, Event>();

            while (true)
            {
                var line = Console.ReadLine();
                if (line == "Time for Code")
                {
                    break;
                }
                var eventMatch = eventsRegex.Match(line);

                if (!eventMatch.Success)
                {
                    continue;
                }
                var id = int.Parse(eventMatch.Groups["id"].Value);
                var eventName = eventMatch.Groups["eventName"].Value;
                var participantsStr = eventMatch.Groups["participiant"].Value;

                var participants = new List<string>();
                if (participantsStr.Length > 0)
                {
                    participants.AddRange(participantsStr
                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                }
                if (!events.ContainsKey(id))
                {
                    var @event = new Event
                    {
                        Name = eventName,
                        Participants = participants
                    };
                    events[id] = @event;
                }
                if (events[id].Name == eventName)
                {
                    events[id].Participants.AddRange(participants);
                }
               
            }

            foreach (var @event in events)
            {
                @event.Value.Participants = @event.Value.Participants.Distinct()
                    .OrderBy(a => a).ToList();

            }
            var sortedEvents = events
                .OrderByDescending(pair => pair.Value.Participants.Count)
                .ThenBy(a => a.Value.Name)
                .Select(a => a.Value)
                .ToArray();
            foreach (var sortedEvent in sortedEvents)
            {
                Console.WriteLine($"{sortedEvent.Name} - {sortedEvent.Participants.Count}");
                foreach (var participant in sortedEvent.Participants)
                {
                    Console.WriteLine(participant);
                }
            }
        }

        class Event
        {
            public string Name { get; set; }
            public List<string> Participants { get; set; }
        }
    }
}
