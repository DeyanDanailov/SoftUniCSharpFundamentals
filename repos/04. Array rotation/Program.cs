using System;

namespace _04._Array_rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            int rotations = int.Parse(Console.ReadLine());
            string temp = "";
            for (int i = 0; i < rotations; i++)
            {
                for (int j = 0; j < arr.Length-1; j++)
                {
                    temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j + 1] = temp;
                }
            }
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
