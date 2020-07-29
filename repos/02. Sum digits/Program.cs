using System;

namespace _02._Sum_digits
{
    class Program
    {
        static void Main(string[] args)
        {

            string strnumber = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < strnumber.Length; i++)
            {
                
                int digit = int.Parse(strnumber[i].ToString());
                sum += digit;
                
            }
            Console.WriteLine(sum);
        }
    }
}
