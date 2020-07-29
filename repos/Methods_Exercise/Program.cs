using System;
using System.Linq;

namespace Methods_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();
            int count = int.Parse(Console.ReadLine());

             if (count > array.Length)
            {
                Console.WriteLine("Invalid count");
                return;            ///kak da izlqza ot metoda???
            }
            int[] newArray = array.Select(int.Parse).ToArray();
            int[] evenArray = new int[count];
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (newArray[i] % 2 == 0)
                {
                    counter++;
                    evenArray[counter - 1] = newArray[i];
                    if (counter == count)
                    {
                        break;
                    }
                }
                
            }
            if (counter > 0 && counter < count)
            {
                int[] newEven = new int[counter];
                for (int i = 0; i < counter; i++)
                {
                    newEven[i] = evenArray[i];
                }
                evenArray = newEven;
            }
            if (counter==0)
            {
                Console.WriteLine("[]");
            }
            Console.WriteLine($"[{String.Join(", ", evenArray)}]");
        }

    }
    }

