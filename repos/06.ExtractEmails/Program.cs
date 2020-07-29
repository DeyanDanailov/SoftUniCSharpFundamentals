using System;
using System.Text.RegularExpressions;

namespace _06.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<=\s|^)[A-Za-z\d]+[.\-_]*[A-Za-z\d]*@[A-Za-z-]+\.[A-Za-z-]+\.?[A-Za-z-]*\b";
            string input = Console.ReadLine();
            MatchCollection mails = Regex.Matches(input, pattern);
            foreach (Match item in mails)
            {
                Console.WriteLine(item.Value);
            }
    }
    }
}
