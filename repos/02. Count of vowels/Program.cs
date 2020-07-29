using System;

namespace _02._Count_of_vowels
{
    class Program
    {
        static int StringNumOfVowels(string input)
        {
            int totalVowels = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='a'|| input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
                {
                    totalVowels++; 
                }
            }
            return totalVowels;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            Console.WriteLine(StringNumOfVowels(input));
        }
    }
}
