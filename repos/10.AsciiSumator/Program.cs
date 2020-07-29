using System;
using System.Collections.Generic;

namespace _10.AsciiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char startSymbol = char.Parse(Console.ReadLine());
            char endSymbol = char.Parse(Console.ReadLine());
            string strToCheck = Console.ReadLine();
            int arrLength = endSymbol - startSymbol;
            int sum = 0;
            List<char> chars = new List<char>();
            for (int i = 1; i < arrLength; i++)
            {
                chars.Add((char)((int)startSymbol + i));
            }
            for (int i = 0; i < strToCheck.Length; i++)
            {
                if (chars.Contains(strToCheck[i]))
                {
                    sum += strToCheck[i];
                }
            }
            Console.WriteLine(sum);
            //Console.WriteLine(String.Join(" ", chars));
        }
    }
}
