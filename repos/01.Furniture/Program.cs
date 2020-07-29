using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> allFurniture = new List<string>();
            string pattern = @">>(?<furniture>[A-Za-z]+)<<(?<price>[\d\.]+)!(?<quantity>\d+)\b";
            double sum = 0.0;
            while (input!= "Purchase")
            {   if (Regex.IsMatch(input, pattern))
                {
                    Match match = Regex.Match(input, pattern);
                    string furniture = match.Groups["furniture"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    sum += price * quantity;
                    allFurniture.Add(furniture);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Bought furniture:");
            foreach (var item in allFurniture)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {sum:f2}");
            
        }
    }
}
