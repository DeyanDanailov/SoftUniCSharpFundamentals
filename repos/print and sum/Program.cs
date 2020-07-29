using System;

namespace print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var startnumber = int.Parse(Console.ReadLine());
            var endnumber = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = startnumber; i <= endnumber; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
