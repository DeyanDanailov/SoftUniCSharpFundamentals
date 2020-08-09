using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _10._2.SongEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            while (text != "end")
            {
                Match isValid = Regex.Match(text, @"^(?<singer>[A-Z][a-z ']+):(?<song>[A-Z ]+)$");
                if (isValid.Success)
                {
                    int key = isValid.Groups["singer"].Length;
                    StringBuilder decrypted = new StringBuilder();
                    foreach (var symbol in text)
                    { 
                        char toAppend;
                        if (symbol >= 65 && symbol <= 90)
                        {
                            if (key + symbol > 90)
                            {
                                toAppend = (char)(key + symbol - 26);
                            }
                            else
                            {
                                toAppend = (char)(key + symbol);
                            }
                            decrypted.Append(toAppend);
                        }
                        else if (symbol >= 97 && symbol <= 122)
                        {
                            if (key + symbol > 122)
                            {
                                toAppend = (char)(key + symbol - 26);
                            }
                            else
                            {
                                toAppend = (char)(key + symbol);
                            }
                            decrypted.Append(toAppend);
                        }
                        else if (symbol == ':')
                        {
                            decrypted.Append('@');
                        }
                        else
                        {
                            decrypted.Append(symbol);
                        }
                    }
                    Console.WriteLine($"Successful encryption: {decrypted}");
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                text = Console.ReadLine();
            }
        }
    }
}
