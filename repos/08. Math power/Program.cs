using System;

namespace _08._Math_power
{
    class Program
    {
        static double MathPow (double number, double pow)
        {
            double result = Math.Pow(number, pow);
            return result;
        }
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double pow = double.Parse(Console.ReadLine());
            Console.WriteLine(MathPow(num, pow));
        }
    }
}
