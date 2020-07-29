using System;

namespace _06._Triples_of_latin_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 97; i < 97+input; i++)
            {
                for (int j = 97; j <97+input ; j++)
                {
                    for (int k = 97; k <97+input; k++)
                    {
                        Console.WriteLine($"{(char)i}{(char)j}{(char)k}");
                    }
                }
            }
        }
    }
}
