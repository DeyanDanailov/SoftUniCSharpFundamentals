using System;

namespace _03._Printing_triangle
{
    class Program
    {
        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int j = 1; j <= input; j++)
            {
                PrintLine(1, j);
            }
            for (int j = input - 1; j > 0; j--)
            {
                PrintLine(1, j);
            }
        }
    }
}
