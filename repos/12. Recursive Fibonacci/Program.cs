using System;
using System.Linq;

namespace _12._Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int elem = arr.Length / 4;
            int[] arrNew = new int[arr.Length / 2];
            for (int i = 0; i <arr.Length/4; i++) //namirame pyrvata chast na noviq masiv
            {
                arrNew[i] = arr[(arr.Length / 4)- 1-i];
            }
            for (int j = 0; j < arr.Length/4; j++) // namirame vtorata chast
            {
                arrNew[arr.Length/2-1 -j] = arr[(arr.Length * 3) / 4 +j];
            }
            int[] arrLeft = new int[arr.Length / 2];
            for (int l = 0; l < arr.Length/2; l++) // namirame ostanalata chast ot pyrvonachalniq masiv
            {
                arrLeft[l] = arr[arr.Length / 4 + l];
            }
            
            int[] result = new int[arr.Length / 2];
            for (int k = 0; k < arr.Length/2; k++) // sybirame dvata novi masiva
            {
                result[k] = arrLeft[k] + arrNew[k];
            }
            Console.WriteLine(String.Join(" ", result));

        }
    }
}
