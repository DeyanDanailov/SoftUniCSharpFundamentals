using System;

namespace _01._Smallest_of_three
{
    class Program
    {
        static int SmallestOfThree(int firstNum, int secondNum, int thirdNum)
        {
            return Math.Min(firstNum, Math.Min(secondNum, thirdNum));
        }
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            Console.WriteLine(SmallestOfThree(first, second, third));
        }
    }
}
