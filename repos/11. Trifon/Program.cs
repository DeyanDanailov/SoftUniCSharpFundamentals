using System;
using System.Linq;

namespace _11._Trifon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] commandArr = new string[command.Length];
                commandArr = command.Split().ToArray();
                if (commandArr[0] == "exchange")
                {
                   arr = Exchange(arr, int.Parse(commandArr[1]));                   
                }
                else if (commandArr[0] == "max")
                {

                    if (commandArr[1] == "odd")
                    {
                        MaxEvenOddNum(arr, 1);
                    }
                    else if (commandArr[1] == "even")
                    {
                        MaxEvenOddNum(arr, 0);
                    }
                }
                else if (commandArr[0] == "min")
                {
                    if (commandArr[1] == "odd")
                    {
                        MinEvenOddNum(arr, 1);
                    }
                    else if (commandArr[1] == "even")
                    {
                        MinEvenOddNum(arr, 0);

                    }
                
                }
                else if (commandArr[0] == "first")
                {
                    if (commandArr[2] == "odd")
                    {
                        FirstCountEvenOddElements(arr, int.Parse(commandArr[1]), 1);
                    }
                    else if (commandArr[2] == "even")
                    {
                        FirstCountEvenOddElements(arr, int.Parse(commandArr[1]), 0);
                    }
                }
                else if (commandArr[0] == "last")
                {
                    if (commandArr[2] == "odd")
                    {
                        LastCountEvenOddElements(arr, int.Parse(commandArr[1]), 1);
                    }
                    else if (commandArr[2] == "even")
                    {
                        LastCountEvenOddElements(arr, int.Parse(commandArr[1]), 0);
                    }
                }



                command = Console.ReadLine();
            }
            Console.WriteLine($"[{String.Join(", ", arr)}]");
        }
        static string[] Exchange(string[] array, int splitIndex)
        {
            if (splitIndex < 0 || splitIndex > array.Length - 1)
            {
                Console.WriteLine("Invalid index");
                return array;
            }
            string[] newArray = new string[array.Length];
            for (int i = 0; i < array.Length - 1 - splitIndex; i++) //prezapisvame dqsnata polovina v nov masiv v lqvo
            {
                newArray[i] = array[splitIndex + 1 + i];
            }
            for (int j = array.Length-1 - splitIndex; j < array.Length; j++) // zapisvame lqvata ot stariq masiv v dqsnata na noviq
            {
                newArray[j] = array[j - array.Length+1+splitIndex];
            }
            return newArray; // masivyt e obraboten
        }
        static void MinEvenOddNum(string[] array, int evenOdd)
        {
            int[] newArray = array.Select(int.Parse).ToArray();
            int counterOfEvens = 0;
            int min = 0;
            int minIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (newArray[i] % 2 == evenOdd)
                {
                    counterOfEvens++;
                    if (counterOfEvens == 1)
                    {
                        min = newArray[i];
                        minIndex = i;
                    }
                    else if (counterOfEvens > 1)
                    {
                        if (min >= newArray[i])
                        {
                            min = newArray[i];
                            minIndex = i;
                        }
                    }

                }
            }
            if (counterOfEvens == 0)
            {
                Console.WriteLine("No matches");

            }
            else
            {
                Console.WriteLine(minIndex);
            }
        }
        static void MaxEvenOddNum(string[] array, int evenOdd)
        {
            int[] newArray = array.Select(int.Parse).ToArray();
            int counterOfEvens = 0;
            int max = 0;
            int maxIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (newArray[i] % 2 == evenOdd)
                {
                    counterOfEvens++;
                    if (counterOfEvens == 1)
                    {
                        max = newArray[i];
                        maxIndex = i;
                    }
                    else if (counterOfEvens > 1)
                    {
                        if (max <= newArray[i])
                        {
                            max = newArray[i];
                            maxIndex = i;
                        }
                    }

                }
            }
            if (counterOfEvens == 0)
            {
                Console.WriteLine("No matches");

            }
            else
            {
                Console.WriteLine(maxIndex);
            }
        }
        static void FirstCountEvenOddElements(string[] array, int count, int evenOdd)
        {
            if (count > array.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            int[] newArray = array.Select(int.Parse).ToArray();
            int[] resultArray = new int[count];
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (newArray[i] % 2 == evenOdd)
                {
                    counter++;
                    resultArray[counter - 1] = newArray[i];
                    if (counter == count)
                    {
                        break;
                    }
                }

            }
            if (counter > 0 && counter < count)
            {
                int[] newResult = new int[counter];
                for (int i = 0; i < counter; i++)
                {
                    newResult[i] = resultArray[i];
                }
                resultArray = newResult;
            }
            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            Console.WriteLine($"[{String.Join(", ", resultArray)}]");
        }
        static void LastCountEvenOddElements(string[] array, int count, int evenOdd)
        {
            if (count > array.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            int[] newArray = array.Select(int.Parse).ToArray();
            int[] resultArray = new int[count];
            int counter = 0;
            
            for (int i = resultArray.Length - 1; i >= 0; i--)
            {
                if (newArray[i] % 2 == evenOdd)
                {
                    counter++;
                    
                    resultArray[counter -1] = newArray[i];
                    if (counter == count)
                    {
                        break;
                    }
                }

            }
            
            int[] newResultArray = new int[counter];
            for (int k = 0, j = 0; k < resultArray.Length; k++)
            {
                if (resultArray[k] != 0)
                {
                    newResultArray[j] = resultArray[k];
                    j++;
                }
            }
            
            if (counter > 0 && counter < count) 
            {
               
                Console.WriteLine($"[{String.Join(", ", newResultArray)}]");
            }
            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else if (counter==count)
            {
                Console.WriteLine($"[{String.Join(", ", resultArray)}]");
            }
            
               
            
            
        }
    }
}
