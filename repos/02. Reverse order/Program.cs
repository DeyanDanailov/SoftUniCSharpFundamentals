using System;

namespace _02._Reverse_order
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int j = numbers.Length-1; j >=0; j--)
            {
                Console.Write($"{numbers[j]} ");
            }
        }
    }
}
