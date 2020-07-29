using System;
using System.Linq;

namespace _03._Rounding_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputline = Console.ReadLine().Split();
            double[] numbers = new double[inputline.Length];
           
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(inputline[i]);
                if (numbers[i]==0)
                {
                    numbers[i] = 0;
                }
                Console.WriteLine($"{numbers[i]} => {(int)Math.Round(numbers[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
