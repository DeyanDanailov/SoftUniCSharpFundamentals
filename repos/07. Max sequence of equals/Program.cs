using System;

namespace _07._Max_sequence_of_equals
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            int counter = 1;
            int maxSequence = 1;
            string digit = "";
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    counter++;
                    if (counter>maxSequence)
                    {
                        maxSequence = counter;
                        digit = arr[i];
                    }
                    
                    
                }
                else if (arr[i] != arr[i + 1])
                {
                    counter = 1;

                }

            }
            string[] result = new string[maxSequence];
            for (int j = 0; j < maxSequence; j++)
            {
                result[j] = digit;
            }
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
