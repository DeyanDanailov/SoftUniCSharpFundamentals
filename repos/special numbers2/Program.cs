using System;

namespace special_numbers2
{
    class Program
    {
        static void Main(string[] args)
        {
            int finalNumber = int.Parse(Console.ReadLine());


            int sum = 0;
            for (int i = 1; i <= finalNumber; i++)
{                   
                int j = i;
                while (j > 0)
{
                    sum += j % 10;
                    j = j / 10;
                }
                bool IsSpecial = false;
                if ((sum == 5) || (sum == 7) || (sum == 11))
                    IsSpecial = true;
                Console.WriteLine("{0} -> {1}", i, IsSpecial);
                sum = 0;
               
            }
        }
    }
}
