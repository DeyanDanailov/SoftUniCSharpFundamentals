using System;

namespace _01._Sign_of_integer
{
    class Program
    {
        static void PrintSignOfInteger(int input)
        {
            if (input>0)
            {
                Console.WriteLine($"The number {input} is positive.");
            }
            else if (input==0)
            {
                Console.WriteLine($"The number {input} is zero.");
            }
            else
            {
                Console.WriteLine($"The number {input} is negative.");
            }
        }
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PrintSignOfInteger(input);
        }
    }
}
