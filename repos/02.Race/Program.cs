using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participantsList = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            Dictionary<string, int> participantsRun = new Dictionary<string, int>();
            foreach (var item in participantsList)
            {
                participantsRun[item] = 0;
            }
            string input = Console.ReadLine();
            while (input != "end of race")
            {
                string patternName = @"[A-Za-z]";
                string name = "";
                MatchCollection letters = Regex.Matches(input, patternName);
                foreach (Match item in letters)
                {
                    name += item;
                }
                if (participantsList.Contains(name))
                {
                    string patternDistance = @"\d";
                    MatchCollection km = Regex.Matches(input, patternDistance);
                    foreach (Match item in km)
                    {
                        participantsRun[name] += int.Parse(item.Value);
                    }
                }
                input = Console.ReadLine();
            }
            participantsRun = participantsRun.OrderByDescending(d => d.Value).ToDictionary(a => a.Key, b => b.Value);
            int counter = 0;
            foreach (var item in participantsRun)
            {
                if (counter == 0)
                {
                    Console.WriteLine($"1st place: {item.Key}");
                }
                else if (counter == 1)
                {
                    Console.WriteLine($"2nd place: {item.Key}");
                }
                else if (counter == 2)
                {
                    Console.WriteLine($"3rd place: {item.Key}");
                }
                else if (counter == 3)
                {
                    break;
                }
                counter++;
            }
            
        }
    }
}
