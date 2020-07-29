using System;

namespace _10._Top_number
{
    class Program
    {
        static bool SumOfDigitsDivisibleBy8(int num) {

            int sumOfDigits = 0;
            string strNum = num.ToString();
            for (int i = 0; i < strNum.Length; i++)
            {
                sumOfDigits += (int)strNum[i];
            }
            if (sumOfDigits % 8 == 0)
            {
                return true;
            }
            else return false;
        }
        static bool HoldsAtLeastOneOddDigit(int num)
        {
            string number = num.ToString();
            for (int i = 0; i < number.Length; i++)
            {
                char digit = number[i];
                if (digit == '1' || digit == '3' || digit == '5' || digit == '7' || digit == '9')
                {
                    return true;
                }

            }
            return false;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                if (SumOfDigitsDivisibleBy8(i) && HoldsAtLeastOneOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
