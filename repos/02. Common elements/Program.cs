using System;
using System.Linq;

namespace _02._Common_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();
            string[] common = new string[arr2.Length];
            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = 0; j < arr1.Length; j++)
                {
                    if (arr1[j]==arr2[i])
                    {
                        common[i] = arr1[j];
                    }
                }
            }
            /*string[] result = new string[common.Length];
            for (int k = 0; k < common.Length; k++)
            {
                result[k] = common[k];
                if (common[k]=="")
                {
                    result[k] = common[k + 1];
                }
            }*/
            common = common.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            Console.WriteLine(String.Join(" ",common));
        }
    }
}
