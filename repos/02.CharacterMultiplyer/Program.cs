using System;

namespace _02.CharacterMultiplyer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string first = input[0];
            string second = input[1];
            int sum = 0;
            if (first.Length==second.Length)
            {
                for (int i = 0; i < first.Length; i++)
                {
                    sum += (int)first[i] * (int)second[i];
                }
            }
            else if (first.Length>second.Length)
            {
                for (int i = 0; i < second.Length; i++)
                {
                    sum += (int)first[i] * (int)second[i];
                }
                for (int j = second.Length; j < first.Length; j++)
                {
                    sum += (int)first[j];
                }
            }
            else
            {
                for (int i = 0; i < first.Length; i++)
                {
                    sum += (int)first[i] * (int)second[i];
                }
                for (int j = first.Length; j < second.Length; j++)
                {
                    sum += (int)second[j];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
