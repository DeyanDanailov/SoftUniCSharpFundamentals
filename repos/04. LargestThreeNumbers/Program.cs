using System;
using System.Linq;

namespace _04._LargestThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).OrderByDescending(x=>x).Take(3).ToList();
            //for (int i = 0; i < (numbers.Count < 3 ? numbers.Count : 3); i++)
            //{
            //    Console.Write(numbers[i] + " ");
            //}
            Console.WriteLine(String.Join(" ",numbers));
        }
    }
}
