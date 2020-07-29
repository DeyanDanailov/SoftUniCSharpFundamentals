using System;
using System.Text;

namespace _05.LettersAndDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder otherSymbols = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    digits.Append(input[i]);
                }
                else if (char.IsLetter(input[i]))
                {
                    letters.Append(input[i]);
                }
                else
                {
                    otherSymbols.Append(input[i]);
                }
            }
            string resultDigits = digits.ToString();
            string resultLetters = letters.ToString();
            string resultOtherSymbols = otherSymbols.ToString();
            Console.WriteLine(resultDigits);
            Console.WriteLine(resultLetters);
            Console.WriteLine(resultOtherSymbols);
        }
    }
}
