using System;
using System.Text.RegularExpressions;

namespace _03.SoftUniBar
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sum = 0.0m;
            string pattern = @"^%(?<person>[A-Z]{1}[a-z]+)%[^|$%\.]*<(?<product>\w+)>[^|$%\.]*\|(?<quantity>\d+)\|[^|$%\.]*?(?<price>\d+\.?\d*)\$$";           
            string input;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string person = match.Groups["person"].Value;
                    string product = match.Groups["product"].Value;
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    if (quantity != 0)
                    {
                        decimal result = price * quantity;
                        sum += result;
                        Console.WriteLine($"{person}: {product} - {result:f2}");
                    }
                }

            }
            Console.WriteLine($"Total income: {sum:f2}");
        }
    }
}
