using System;

namespace _04._sum_of_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberofchars = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < numberofchars; i++)
            {
                char input = char.Parse(Console.ReadLine());
                sum += (int)input;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
