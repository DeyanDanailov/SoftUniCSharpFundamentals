using System;

namespace special_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int currentNum = i;
                int num = i;
                int digit = currentNum % 10;
                sum += digit;
                currentNum = currentNum / 10;
                sum += currentNum;
                while (currentNum/10>0)

                {
                    
                    digit = currentNum % 10;
                    sum += digit;
                    currentNum = currentNum / 10;
                }
                if (sum ==5 || sum==7 || sum==11 )
                {
                    Console.WriteLine($"{num} -> True");
                }
                else
                {
                    Console.WriteLine($"{num} -> False");
                }
                sum = 0;
            }
        }
    }
}
