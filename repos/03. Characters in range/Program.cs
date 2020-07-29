using System;

namespace _03._Characters_in_range
{
    class Program
    {
        static void CharsInBetween(char start, char end)
        {
            int result = start.CompareTo(end);
            if (result > 0)
            {
                char temp = start;
                start = end;
                end = temp;
            }
            for (int i = (int)start + 1; i < (int)end; i++)
            {
                Console.Write((char)i + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            CharsInBetween(start, end);

        }
    }
}
