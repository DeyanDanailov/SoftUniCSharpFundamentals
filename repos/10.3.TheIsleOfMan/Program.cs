using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _10._3.TheIsleOfMan
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            while (true)
            {
                Match isValid = Regex.Match(message, @"([#$%*&])(?<name>[A-Za-z]+)\1=(?<length>\d+)!!(?<geohashcode>.*)$");               
                if (isValid.Success)
                {
                    int length = int.Parse(isValid.Groups["length"].Value);
                    int geohashLength = isValid.Groups["geohashcode"].Value.Length;
                    if (length == geohashLength)
                    {
                        string geohashCode = isValid.Groups["geohashcode"].Value;
                        geohashCode = new string(geohashCode.Select(x => (char)(x + length)).ToArray());
                        string name = isValid.Groups["name"].Value;
                        Console.WriteLine($"Coordinates found! {name} -> {geohashCode}");
                        return;
                    }
                }
                Console.WriteLine("Nothing found!");
                message = Console.ReadLine();
            }
        }
    }
}
