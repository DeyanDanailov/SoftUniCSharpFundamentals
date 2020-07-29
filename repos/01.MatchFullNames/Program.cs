using System;
using System.Text.RegularExpressions;

namespace _01.MatchFullNames
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Regex regex = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+");
            string text = Console.ReadLine();
            MatchCollection matches = regex.Matches(text);
            foreach (Match name in matches)
            {
                Console.Write(name.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
