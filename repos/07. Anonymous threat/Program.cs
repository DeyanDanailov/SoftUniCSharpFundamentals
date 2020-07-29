using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Anonymous_threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = Console.ReadLine();
            while (input != "3:1")
            {
                List<string> command = input.Split().ToList();
                if (command[0] == "merge")
                {
                    MergeList(list, int.Parse(command[1]), int.Parse(command[2]));
                }
                else if (command[0] == "divide")
                {
                    DivideList(list, int.Parse(command[1]), int.Parse(command[2]));
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", list));
        }
        static List<string> MergeList(List<string> list, int startIndex, int endIndex)
        {
            if (startIndex < 0)
            {
                if (endIndex < list.Count && endIndex >= 0)
                {
                    startIndex = 0;
                }

            }
            if (endIndex >= list.Count)
            {
                if (startIndex >= 0 && startIndex <= list.Count - 1)
                {
                    endIndex = list.Count - 1;
                }
            }
            if (startIndex < 0 && endIndex > list.Count - 1)
            {
                startIndex = 0;
                endIndex = list.Count - 1;
            }
            if ((startIndex >= 0 && startIndex < list.Count) && (endIndex >= 0 && endIndex < list.Count))
            {
                for (int i = startIndex; i < endIndex; i++)
                {
                    list[startIndex] = list[startIndex] + list[startIndex + 1];
                    list.RemoveAt(startIndex + 1);
                }
            }
            return list;
        }
        static List<string> DivideList(List<string> list, int index, int partition)
        {
            if (index >= 0 && index < list.Count)
            {


                string stringToDivide = list[index];
                list.RemoveAt(index);
                int partsLength = stringToDivide.Length / partition;
                int rest = 0;
                if (stringToDivide.Length % partition != 0)
                {
                    rest = stringToDivide.Length % partition;
                    string lastString = stringToDivide.Substring(stringToDivide.Length - 1 - rest - partsLength);
                    list.Insert(index, lastString);

                    for (int i = partsLength; i < stringToDivide.Length; i++)
                    {
                        string temp = stringToDivide.Substring(stringToDivide.Length - 1 - i - rest - partsLength, partsLength);
                        list.Insert(index, temp);
                    }
                }
                else
                {
                    for (int i = partsLength; i <= stringToDivide.Length; i = i + partsLength)
                    {
                        string temp = stringToDivide.Substring(stringToDivide.Length - i, partsLength);
                        list.Insert(index, temp);
                    }
                }
            }
            return list;
        }
    }
}
