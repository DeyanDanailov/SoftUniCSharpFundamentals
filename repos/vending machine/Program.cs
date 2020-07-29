using System;

namespace vending_machine
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalsum = 0;
            string command = Console.ReadLine();
            

            while (command!="Start")
            {
                double currentAmount = double.Parse(command);
                
                if (currentAmount!=0.1 && currentAmount!=0.2 && currentAmount!= 0.5 && currentAmount!= 1 && currentAmount!=2)
                {
                  
                    Console.WriteLine($"Cannot accept {currentAmount}");
                }
                else
                {
                    totalsum += currentAmount;
                }
               
                command = Console.ReadLine();
            }
            string product = Console.ReadLine().ToLower();

            //&quot;Nuts&quot;, &quot;Water&quot;, &quot;Crisps&quot;, &quot;Soda&quot;, &quot;Coke&quot;. The prices are: 2.0, 0.7, 1.5, 0.8, 1.0
            while (product!= "end")
            {
                switch (product)
                {
                    case "nuts":
                        if (totalsum<2.0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            Console.WriteLine($"Purchased {product.ToLower()}");
                            totalsum -= 2.0;
                        } break;
                    case "water":
                        if (totalsum < 0.7)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            Console.WriteLine($"Purchased {product.ToLower()}");
                            totalsum -= 0.7;
                        }
                        break;
                    case "crisps":
                        if (totalsum < 1.5)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            Console.WriteLine($"Purchased {product.ToLower()}");
                            totalsum -= 1.5;
                        }
                        break;
                    case "soda":
                        if (totalsum < 0.8)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            Console.WriteLine($"Purchased {product.ToLower()}");
                            totalsum -= 0.8;
                        }
                        break;
                    case "coke":
                        if (totalsum < 1.0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            Console.WriteLine($"Purchased {product.ToLower()}");
                            totalsum -= 1.0;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                product = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Change: {totalsum:F2}");
        }
    }
}
