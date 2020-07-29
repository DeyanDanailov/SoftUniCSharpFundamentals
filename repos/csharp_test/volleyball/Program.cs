using System;

namespace volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double toyprice = double.Parse(Console.ReadLine());
            int toys = 0;
            double savedmoney = 0.0;
            double realmoney = 0.0;
            for(int i =1; i<=age; i++)
            {
                if (i % 2 == 1)
                    toys++;
                else if (i % 2 == 0)
                {
                    savedmoney += 10;
                    realmoney = realmoney + savedmoney - 1;
                }
            }
            double sum = 0.0;
            sum = realmoney + toys * toyprice;
            if (sum >= price)
            {
               
                Console.WriteLine($"yes {sum-price:f2} leva left!");
            }
            else
                Console.WriteLine($"no {price - sum:F2} leva needed!");
        }
    }
}
