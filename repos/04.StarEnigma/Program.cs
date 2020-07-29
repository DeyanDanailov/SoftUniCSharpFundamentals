using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMessages = int.Parse(Console.ReadLine());
            List<string> attacked = new List<string>();
            List<string> destroyed = new List<string>();
            for (int i = 0; i < numberOfMessages; i++)
            {
                string input = Console.ReadLine();
                MatchCollection letters = Regex.Matches(input, @"[STARstar]");
                int key = letters.Count;
                string decrypted = String.Empty;
                for (int j = 0; j < input.Length; j++)
                {
                    decrypted += (char)(input[j] - key);
                }
                string pattern = @"@(?<planet>[A-Za-z]+)[^@\-!:>]*:(?<population>[\d]+)[^@\-!:>]*!(?<attOrDeff>[AD]{1})![^@\-!:>]*->(?<soldiers>[\d]+)";
                Match match = Regex.Match(decrypted, pattern);
                if (match.Success)
                {
                    if (match.Groups["attOrDeff"].Value == "A")
                    {
                        attacked.Add(match.Groups["planet"].Value);
                    }
                    else if (match.Groups["attOrDeff"].Value == "D")
                    {
                        destroyed.Add(match.Groups["planet"].Value);
                    }
                }
            }
            Console.WriteLine($"Attacked planets: {attacked.Count}");           
            if (attacked.Count>0)
            {
                attacked = attacked.OrderBy(x=>x).ToList();
                foreach (var item in attacked)
                {
                    Console.WriteLine($"-> {item}");
                }
            }
            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            if (destroyed.Count > 0)
            {
                destroyed = destroyed.OrderBy(x => x).ToList();
                foreach (var item in destroyed)
                {
                    Console.WriteLine($"-> {item}");
                }
            }
        }
    }
}
