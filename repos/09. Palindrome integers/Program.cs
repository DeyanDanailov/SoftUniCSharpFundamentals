using System;
using System.Linq;

namespace _09._Palindrome_integers
{
    class Program
    {
        public static bool IsPalindrome(string num)
        {
            char[] arr = num.ToCharArray();
            Array.Reverse(arr);
            string reversed = String.Join("", arr);
            int result = num.CompareTo(reversed);
            if (result == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                Console.WriteLine(IsPalindrome(input).ToString().ToLower());

                input = Console.ReadLine();
            }
        }
    }
}
