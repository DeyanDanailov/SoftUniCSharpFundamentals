using System;
using System.Numerics;
namespace _03._BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial.Calculate(n)); 
            
        }
    }
    public class Factorial
    {
        public static BigInteger Calculate(int n)
        {
            BigInteger result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
