using System;
using System.Text.RegularExpressions;

namespace _7._2.Password
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match isValid = Regex.Match(input, @"(.+)>(?<first>\d{3})\|(?<second>[a-z]{3})\|(?<third>[A-Z]{3})\|(?<fourth>[^<>]{3})<\1");
                if (isValid.Success)
                {
                    string result = String.Concat(isValid.Groups["first"].Value, isValid.Groups["second"].Value, isValid.Groups["third"].Value, isValid.Groups["fourth"].Value);
                    Console.WriteLine($"Password: {result}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
