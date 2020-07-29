using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombSquad = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Detonation(numbers, bombSquad[0], bombSquad[1]);
            Console.WriteLine(numbers.Sum());
        }
        static List<int> Detonation(List<int> list, int bomb, int range)
        {
            int bombIndex = list.IndexOf(bomb);
            while (bombIndex!=-1)
            {
                int leftNumber = bombIndex - range;
                int rightNumber = bombIndex + range;
                if (leftNumber<0)
                {
                    leftNumber = 0;
                }
                if (rightNumber > list.Count-1)
                {
                    rightNumber = list.Count - 1;
                }
                list.RemoveRange(leftNumber, rightNumber-leftNumber+1);
                bombIndex = list.IndexOf(bomb);
                //for (int j = 0; j < list.Count; j++)
                //{
                //    if (list[j] == bomb)
                //    {
                //        index = j;
                //        break;
                //    }
                //}

                //list.RemoveAt(index);

                //for (int i = 0; i < range * 2; i++)
                //{
                //    if (index - range >= list.Count)
                //    {
                //        break;
                //    }
                //    else
                //    {
                //        list.RemoveAt(index - range);
                //    }
                //}
            }
            return list;
        }


    }
}
