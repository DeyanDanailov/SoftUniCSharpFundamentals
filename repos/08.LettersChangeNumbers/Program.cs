using System;

namespace _08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            decimal sum = 0;
            decimal leftResult;
            decimal rightResult;
            for (int i = 0; i < input.Length; i++)
            {
                string letterDigit = input[i];
                string num = "";
                for (int j = 1; j < letterDigit.Length - 1; j++)
                {
                    num += letterDigit[j];
                }
                decimal leftNum = decimal.Parse(num);
                               
                if (char.IsUpper(letterDigit[0]))
                {
                    int position = letterDigit[0] - 64;
                    leftResult = LetterDigitResultDivide(leftNum, position);
                }
                else
                {
                    int position = (letterDigit[0]) - 96;
                    leftResult = LetterDigitResultMultiply(leftNum, position);
                }
                if (char.IsUpper(letterDigit[letterDigit.Length - 1]))
                {
                    int position = letterDigit[letterDigit.Length - 1] - 64;
                    rightResult = LetterDigitResultSubtract(leftResult, position);
                }
                else
                {
                    int position = letterDigit[letterDigit.Length - 1] - 96;
                    rightResult = LetterDigitResultAdd(leftResult, position);
                }
                sum += rightResult;
                
            }
            Console.WriteLine($"{sum:f2}");
        }
        static decimal LetterDigitResultAdd(decimal result, int position)
        {
            decimal finalResult = result + position;
            return finalResult;
        }
        static decimal LetterDigitResultSubtract(decimal result, int position)
        {
            decimal finalResult = result - position;
            return finalResult;
        }
        static decimal LetterDigitResultDivide(decimal number, int position)
        {
            decimal result = number / (position);
            return result;
        }
        static decimal LetterDigitResultMultiply(decimal number, int position)
        {
            decimal result = number * position;
            return result;
        }
    }
}
