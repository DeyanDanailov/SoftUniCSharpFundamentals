using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _11._2.Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, @"(={1,}|\/{1,})(?<destination>[A-Z]{1}[A-Za-z]{2,})\1");
            int travelPoints = 0;
            List<string> results = new List<string>();
            foreach (Match item in matches)
            {
                travelPoints += item.Groups["destination"].Value.Length;
                results.Add(item.Groups["destination"].Value);
            }
            Console.WriteLine($"Destinations: {String.Join(", ", results)}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
