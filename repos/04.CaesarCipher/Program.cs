using System;
using System.Text;

namespace _04.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder encrypted = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                char newSymbol = (char)(input[i] + 3);
                encrypted.Append(newSymbol);
            }
            Console.WriteLine(encrypted);
        }
    }
}
