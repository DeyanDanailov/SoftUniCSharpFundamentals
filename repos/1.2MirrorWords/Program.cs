using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _1._2MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            MatchCollection wordPairs = Regex.Matches(input, @"([@#])(?<word1>[A-Za-z]{3,})\1{2}(?<word2>[A-Za-z]{3,})\1");
            List<string> mirrorWords = new List<string>();
            foreach (Match pair in wordPairs)
            {
                string firstWord = pair.Groups["word1"].Value;
                string secondWord = pair.Groups["word2"].Value;
                char[] reversed = secondWord.ToCharArray().Reverse().ToArray();
                string secondWordReversed = new string(reversed);
                if (firstWord == secondWordReversed)
                {
                    mirrorWords.Add(firstWord);
                }
            }
            if (wordPairs.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine($"{wordPairs.Count} word pairs found!");
                if (mirrorWords.Count == 0)
                {
                    Console.WriteLine("No mirror words!");
                }
                else
                {
                    Console.WriteLine("The mirror words are:");
                    for (int i = 0; i < mirrorWords.Count; i++)
                    {
                        char[] reversed = mirrorWords[i].ToCharArray().Reverse().ToArray();
                        string mirror = new string(reversed);
                        if (i == mirrorWords.Count - 1)
                        {
                         Console.WriteLine($"{mirrorWords[i]} <=> {mirror}");                           
                        } else
                        Console.Write($"{mirrorWords[i]} <=> {mirror}, ");
                    }
                }
            }
        }
    }
}
