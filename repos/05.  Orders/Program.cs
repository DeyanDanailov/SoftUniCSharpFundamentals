using System;

namespace _05.__Orders
{
    class Program
    {
        static void Order(string product, int quantity)
        {
            double price = 0;
            double result = 0;
            switch (product)
            {
                case "coffee":
                    price = 1.50;
                    break;
                case "water":
                    price = 1.00;
                    break;
                case "coke":
                    price = 1.40;
                    break;
                case "snacks":
                    price = 2.00;
                    break;
                default:
                    break;
            }
            result = price * quantity;
            Console.WriteLine($"{result:f2}");
        }
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            Order(product, quantity);
        }
    }
}
