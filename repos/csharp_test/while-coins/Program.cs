using System;

namespace while_coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            sum = sum*100;
            int res = Convert.ToInt32(sum);
            int coins = 0;
            
                
                coins = res / 200;
                res = res % 200;
                coins = coins + res / 100;
                res = res % 100;
                coins = coins + res / 50;
                res = res % 50;
                coins = coins + res / 20;
                res = res % 20;
                coins = coins + res / 10;
                res = res % 10;
                coins = coins + res / 5;
                res = res % 5;
                coins = coins + res / 2;
                res = res % 2;
                coins = coins + res / 1;
                res = res % 1;
            
            Console.WriteLine($"{coins}");
        }
    }
}
