using System;
using System.Text.RegularExpressions;

namespace _2._2FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string barcode = Console.ReadLine();
                Match valid = Regex.Match(barcode, @"^@#+[A-Z][A-Za-z\d]{4,}[A-Z]@#+$");
                if (valid.Success)
                {
                    MatchCollection digits = Regex.Matches(barcode, @"\d");
                    if (digits.Count==0)
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    else
                    {
                        string productGroup = String.Empty;
                        foreach  (Match digit in digits)
                        {
                            productGroup += digit;
                        }
                        Console.WriteLine($"Product group: {productGroup}");
                    }                  
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
           
        }
    }
}
