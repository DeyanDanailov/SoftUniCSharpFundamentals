using System;
using System.Linq;

namespace _08._Array_to_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            
            while (nums.Length != 1)
            {
                int[] newArr = new int[nums.Length - 1];
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    newArr[i] = nums[i] + nums[i + 1];
                }
                nums = newArr;
            }
            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
