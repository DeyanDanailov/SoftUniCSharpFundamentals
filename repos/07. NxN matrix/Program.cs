using System;

namespace _07._NxN_matrix
{
    class Program
    {
        static void PrintLine(int num)
        {
            int[] row = new int[num];
            for (int i = 0; i < num; i++)
            {
                row[i] = num;
            }
            Console.WriteLine(String.Join(" ", row));
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                PrintLine(num);
            }
        }
    }
}
