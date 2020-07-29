using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_of_products
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = EnterProducts();
            NumberProducts(products);
        }
        static List<string> EnterProducts()
        {
            int n = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();
            for (int i = 0; i < n; i++)
            {
                products.Add(Console.ReadLine());
            }
            products = products.OrderBy(name => name).ToList();
            return products;
        }
        static void NumberProducts(List<string> products)
        {
            for (int i = 1; i <= products.Count; i++)
            {
                Console.WriteLine($"{i}.{products[i - 1]}");
            }

        }
    }
}
