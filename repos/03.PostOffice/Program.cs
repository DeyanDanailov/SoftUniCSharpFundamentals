using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.PostOffice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] parts = Console.ReadLine().Split('|').ToArray();
            string[] words = parts[2].Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string capLetters = Regex.Match(parts[0], @"([#\$%\*&])(?<capLetters>[A-Z]+)\1").Groups["capLetters"].Value.ToString();
            MatchCollection asciiCodes = Regex.Matches(parts[1], @"(?<ascii>\d{2}):(?<length>\d{2})");
            List<string> result = new List<string>();
            foreach (var letter in capLetters)
            {
                int lettercode = (int)letter;
                foreach (Match code in asciiCodes)
                {
                    if (int.Parse(code.Groups["ascii"].Value)==lettercode)
                    {
                        foreach (var word in words)
                        {
                            if (word[0]==(char)lettercode && (word.Length-1)==int.Parse(code.Groups["length"].Value) && !result.Contains(word))
                            {
                                Console.WriteLine(word);
                                result.Add(word);
                            }
                        }
                    }
                }
            }
        }
    }
}
