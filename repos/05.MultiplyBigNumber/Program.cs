using System;
using System.Text;

namespace _05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine().TrimStart('0');
            int multiplier = int.Parse(Console.ReadLine());
            StringBuilder product = new StringBuilder();
            int left = 0;
            if (multiplier==0 || bigNumber=="")
            {
                Console.WriteLine('0');
                return;

            }
            //while (bigNumber[0] == '0')
            //{
            //    bigNumber = bigNumber.Substring(1);
            //}
            for (int i = bigNumber.Length-1; i >= 0; i--)
            {
                int digit = Convert.ToInt32(new string(bigNumber[i], 1));
                int result = digit * multiplier + left;
                int toRecord = result % 10;
                left = result / 10;
                product.Append(toRecord.ToString());
                
            }
            if (left > 0)
            {
                product.Append(left.ToString());
            }
            StringBuilder finalResult = new StringBuilder();
           
            for (int j = product.Length-1; j>=0; j--)
           
                finalResult.Append(product[j]);
            Console.WriteLine(finalResult);
        }
    }
    }

