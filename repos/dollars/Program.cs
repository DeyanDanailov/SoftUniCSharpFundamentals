using System;

namespace dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num = decimal.Parse(Console.ReadLine());
            decimal result = num * 1.31m;
            Console.WriteLine($"{result:F3}");
        }
    }
}
