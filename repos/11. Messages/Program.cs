using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<string> text = Console.ReadLine().Split("").ToList();
            List<string> message = new List<string>();
            List<string> symbols = MakeTextToSymbols(text);
            for (int i = 0; i < numbers.Count; i++)
            {
                int number = numbers[i];
                int sum = FindSumOfDigits(number);
                int indexOfLetter = sum % symbols.Count;
                message.Add(symbols[indexOfLetter]);
                symbols.RemoveAt(indexOfLetter);
            }
            Console.WriteLine(String.Join("", message));
        }
        static int FindSumOfDigits(int num)
        {
            int sum = num.ToString().Sum(c => c - '0');
            //int sum = 0;
            //while (num>0)
            //{
            //    sum += num % 10;
            //    num = num / 10;
            //}
            return sum;
        }
        static List<string> MakeTextToSymbols (List<string> list)
        {
            List<string> symbols = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {
                bool IsLastLetter = false;
                string element = list[i];
                for (int j = 0; j <= element.Length-1; j++)
                {
                    string letter = element[j].ToString();
                    symbols.Add(letter);
                    if (j == (element.Length - 1))
                    {
                        IsLastLetter=true;
                    }

                }
                if (IsLastLetter)
                {
                    break;
                }
                symbols.Add(String.Empty);
            }

            return symbols;
        }
       
    }

}
