using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _5._2MessageTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string message = Console.ReadLine();
                Match isValid = Regex.Match(message, @"!(?<text>[A-Z][a-z]{2,})!:\[(?<mess>[A-Za-z]{8,})\]");
                if (isValid.Success)
                {
                    List<char> chars = isValid.Groups["mess"].Value.ToList();
                    string text = isValid.Groups["text"].Value;
                    List<int> result = new List<int>();
                    foreach (var item in chars)
                    {
                        result.Add((int)item);
                    }
                    Console.WriteLine($"{text}: {String.Join(' ',result)}");
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }
        }
    }
}
