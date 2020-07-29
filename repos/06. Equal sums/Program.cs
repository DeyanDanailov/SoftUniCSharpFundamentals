using System;
using System.Linq;

namespace _06._Equal_sums
{
    class Program
    {
        static void Main(string[] args)
       {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumLeft = 0;
            int sumRight = 0;
            bool equalsums = false;
            int i = 0;
            for (i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {

                    if (i>j)
                    {
                        sumLeft += arr[j];
                    }
                    else if (i<j)
                    {
                        sumRight += arr[j];
                    }
                }
                if (sumLeft==sumRight)
                {
                    equalsums = true;
                   
                    break;
                }
                sumLeft = 0;
                sumRight = 0;
            }
            if (equalsums)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine("no");
            }
 
        }
    }
}
