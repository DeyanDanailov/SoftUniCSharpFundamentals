using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, @"\+359([ -])2\1\d{3}\1\d{4}\b");
            List<string> result = new List<string>();
            foreach (Match item in matches)
            {
                result.Add(item.Value);
            }
            Console.WriteLine(String.Join(", ", result));
        }
    }
}
