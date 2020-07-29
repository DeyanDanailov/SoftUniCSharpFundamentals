using System;

namespace _03._Zig_zag_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr1 = new string[n];
            string[] arr2 = new string[n];
            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split();
                if (i%2==0)
                {
                    arr1[i] = arr[0];
                    arr2[i] = arr[1];
                }
                else if(i%2==1)
                {
                    arr1[i] = arr[1];
                    arr2[i] = arr[0];
                }
            }
            Console.WriteLine(String.Join(" ", arr1));
            Console.WriteLine(String.Join(" ", arr2));
        }
    }
}
