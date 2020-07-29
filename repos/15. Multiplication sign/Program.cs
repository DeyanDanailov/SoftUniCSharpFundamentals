using System;

namespace _15._Multiplication_sign
{
    class Program
    {
        static void Tribonacci(int num) {
            int[] tribonacci = new int[num];
            tribonacci[0] = 1;
            tribonacci[1] = 1;
            tribonacci[2] = 2;
            for (int i = 3; i < num; i++)
            {
                tribonacci[i] = tribonacci[i - 1] + tribonacci[i - 2] + tribonacci[i - 3];
            }
            if (num==2)
            {
                Console.WriteLine("1 1 2");
            }
            else if (num==1)
            {
                Console.WriteLine("1 1");
            }
            else
            {
                Console.WriteLine(String.Join(" ", tribonacci));
            }
           

        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Tribonacci(num);
        
        }
    }
}
