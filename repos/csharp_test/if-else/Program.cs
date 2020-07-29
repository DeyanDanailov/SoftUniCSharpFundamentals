using System;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string grade = Console.ReadLine();
            double price = 0.0;
            double discount = 0.0;

            if (room == "room for one person")
            {
                price = 18 * (days-1);
            }
            else if (room == "apartment")
            {
                price = 25 * (days-1);
                if (days < 10)
                {
                    discount = 0.3 * price;
                } else if(days >=10 && days <=15) {
                    discount = 0.35 * price;
                } else if (days > 15)
                {
                    discount = 0.5 * price;
                }
            }
            else if (room == "president apartment")
            {
                price = 35 * (days-1);
                if (days < 10)
                {
                    discount = 0.1 * price;
                }
                else if (days >= 10 && days <= 15)
                {
                    discount = 0.15 * price;
                }
                else if (days > 15)
                {
                    discount = 0.2 * price;
                }
            }
            price = price - discount;
            if (grade == "positive")
            {
                price = 1.25 * price;
            } else if (grade == "negative")
            {
                price = 0.9 * price;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
