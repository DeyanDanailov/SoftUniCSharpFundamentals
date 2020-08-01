using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _3._2EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            BigInteger threshold = 1;
            foreach (var item in text)
            {
                if (Char.IsDigit(item))
                {
                    threshold *= int.Parse(item.ToString());
                }
            }
            MatchCollection emojis = Regex.Matches(text, @"(:{2}|\*){2}(?<emoji>[A-Z][a-z]{2,})(\1)");
            List<string> coolEmojis = new List<string>();
            foreach (Match emoji in emojis)
            {
                string symbolsToMultiply = emoji.Groups["emoji"].Value;
                BigInteger coolness = 0;
                foreach (char symbol in symbolsToMultiply)
                {
                    coolness += symbol;
                }
                if (coolness>threshold)
                {
                    coolEmojis.Add(emoji.ToString());
                }
                
            }
            Console.WriteLine($"Cool threshold: {threshold}");
            Console.WriteLine($"{emojis.Count} emojis found in the text. The cool ones are:");
            if (coolEmojis.Count>0)
            {
                Console.WriteLine(String.Join(Environment.NewLine, coolEmojis));
            }
            
        }
    }
}
