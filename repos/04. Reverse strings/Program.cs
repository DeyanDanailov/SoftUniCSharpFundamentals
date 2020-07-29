using System;
using System.Linq;

namespace _04._Reverse_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputline = Console.ReadLine();
            string[] input = inputline.Split();
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write((input[input.Length - i - 1]) + " ");
            }
        }
    }
}
