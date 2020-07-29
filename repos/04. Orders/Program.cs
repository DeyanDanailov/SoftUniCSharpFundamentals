using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new Dictionary<string, double[]>();
            string input = Console.ReadLine();
            while (input!= "buy")
            {
                string[] productArray = input.Split().ToArray();
                string productName = productArray[0];
                double productPrice = double.Parse(productArray[1]);
                double productQuantity = double.Parse(productArray[2]);
                if (!products.ContainsKey(productName))
                {
                    products[productName] = new double[2];
                }
                products[productName][0] = productPrice;
                products[productName][1] += productQuantity;

                input = Console.ReadLine();
            }
            
            foreach (var item in products)
            {
                Console.WriteLine($"{item.Key} -> {item.Value[0]*item.Value[1]:f2}");
            }

            
        }
    }
}
