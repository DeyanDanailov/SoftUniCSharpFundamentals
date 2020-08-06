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
                Match isValid = Regex.Match(message, @"^(\${1}|\%{1})(?<tag>[A-Z]{1}[a-z]{2,})\1: \[(?<first>[\d]+)\]\|\[(?<second>[\d]+)\]\|\[(?<third>[\d]+)\]\|$");
                if (isValid.Success)
                {
                    string tag = isValid.Groups["tag"].Value;
                    int first = int.Parse(isValid.Groups["first"].Value);
                    int second = int.Parse(isValid.Groups["second"].Value);
                    int third = int.Parse(isValid.Groups["third"].Value);
                    Console.WriteLine($"{tag}: {(char)first} {(char)second} {(char)third}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
