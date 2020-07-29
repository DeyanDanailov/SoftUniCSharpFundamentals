using System;

namespace vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            var type = Console.ReadLine();
            var day = Console.ReadLine();
            double totalprice = 0;
            if (type=="Students")
            {
                if (day=="Friday")
                {
                    totalprice = number * 8.45;
                } else if (day == "Saturday")
                {
                    totalprice = number * 9.80;
                } else if (day == "Sunday")
                {
                    totalprice = number * 10.46;
                }
                if (number>=30)
                {
                    totalprice = 0.85 * totalprice;
                }
            } else if (type == "Business")
            {
                if (day == "Friday")
                {
                    totalprice = number * 10.90;
                    if (number >= 100)
                    {
                        totalprice = totalprice - 109;
                    }
                }
                else if (day == "Saturday")
                {
                    totalprice = number * 15.60;
                    if (number >= 100)
                    {
                        totalprice = totalprice - 156;
                    }
                }
                else if (day == "Sunday")
                {
                    totalprice = number * 16.00;
                    if (number >= 100)
                    {
                        totalprice = totalprice - 160;
                    }
                }
                
            } else if (type == "Regular")
            {
                if (day == "Friday")
                {
                    totalprice = number * 15.00;
                }
                else if (day == "Saturday")
                {
                    totalprice = number * 20.00;
                }
                else if (day == "Sunday")
                {
                    totalprice = number * 22.50;
                }
                if (number >= 10 && number<=20)
                {
                    totalprice = 0.95 * totalprice;
                }
            }
            Console.WriteLine($"Total price: {totalprice:F2}");
        }
    }
}
