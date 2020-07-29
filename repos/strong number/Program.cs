using System;

namespace strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int tempNum = num;
            string strnum = "";
            strnum += num;
            int sum = 0;
            for (int i = 0; i < strnum.Length; i++)
            {
                int currentdigit = tempNum % 10;
                tempNum = tempNum / 10;
                int factorial =1;
                for (int j = 1; j <= currentdigit; j++)
                {
                    factorial *= j;
                }
                sum += factorial;
            }
            if (sum==num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
