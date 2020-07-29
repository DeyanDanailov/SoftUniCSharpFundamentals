using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _08.ChochkoGamer
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            MatchCollection symbols = Regex.Matches(input, @"[^\d]");
            string uniqueSymbols = String.Empty;
            foreach (Match symbol in symbols)
            {
                if (!uniqueSymbols.Contains(symbol.Value))
                {
                    uniqueSymbols += symbol.Value;
                }
            }
            Console.WriteLine($"Unique symbols used: {uniqueSymbols.Length}");

            MatchCollection pairs = Regex.Matches(input, @"(?<string>[^\d]{1,20})(?<times>\d{1,2})");
            
            StringBuilder result = new StringBuilder();
            //List<string> result = new List<string>();
            foreach (Match item in pairs)
            {
                int times = int.Parse(item.Groups["times"].Value);
                
                for (int i = 0; i < times; i++)
                {
                    result.Append(item.Groups["string"].Value);
                }             
            }
            Console.WriteLine(String.Join("", result));
        }
    }
}
