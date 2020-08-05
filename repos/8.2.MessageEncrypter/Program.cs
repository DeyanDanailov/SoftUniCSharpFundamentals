using System;
using System.Text.RegularExpressions;

namespace _8._2.MessageEncrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string message = Console.ReadLine();
                Match isValid = Regex.Match(message, @"(\*{1}|\@{1})(?<tag>[A-Z]{1}[a-z]{2,})\1: \[(?<first>[A-Za-z])\]\|\[(?<second>[A-Za-z])\]\|\[(?<third>[A-Za-z])\]\|$");
                if (isValid.Success)
                {
                    string tag = isValid.Groups["tag"].Value;
                    char first = char.Parse(isValid.Groups["first"].Value);
                    char second = char.Parse(isValid.Groups["second"].Value);
                    char third = char.Parse(isValid.Groups["third"].Value);
                    Console.WriteLine($"{tag}: {(int)first} {(int)second} {(int)third}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
