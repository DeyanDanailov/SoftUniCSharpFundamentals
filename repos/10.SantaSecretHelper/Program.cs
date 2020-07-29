using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _10.SantaSecretHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string decrypted = String.Empty;
            while (input != "end")
            {
                foreach (var item in input)
                {
                    decrypted += (char)(item - key);
                }
                
                Match command = Regex.Match(decrypted, @"@(?<child>[A-Za-z]+)[^@\-!:>]*!(?<goodNaughty>[GN])!");
                string name = command.Groups["child"].Value;
                string goodNaughty = command.Groups["goodNaughty"].Value;
                if (goodNaughty=="G")
                {
                    Console.WriteLine(name);
                }
                decrypted = String.Empty;
                input = Console.ReadLine();
            }
        }
    }
}
