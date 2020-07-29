using System;

namespace _06._Middle_chars
{
    class Program
    {
        static void ReturnMiddleCharsOfString(string input)
        {
            if (input.Length % 2==0)
            {
                Console.WriteLine($"{input[input.Length/2-1]}{input[input.Length/2]}");
            }
            else
            {
                Console.WriteLine(input[input.Length / 2]);
            }
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            ReturnMiddleCharsOfString(input);
        }
    }
}
