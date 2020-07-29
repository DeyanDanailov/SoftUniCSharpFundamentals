using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._2_ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine().Split("!", StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = Console.ReadLine();
            while (input != "Go Shopping!")
            {
                List<string> command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                if (command[0]=="Urgent")
                {
                    Urgent(shoppingList, command[1]);
                }
                else if (command[0]=="Unnecessary")
                {
                    Unnecessary(shoppingList, command[1]);
                }
                else if (command[0]=="Correct")
                {
                    Correct(shoppingList, command[1], command[2]);
                }
                else if (command[0]=="Rearrange")
                {
                    Rearrange(shoppingList, command[1]);
                }


                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(", ", shoppingList));
        }
        static List<string> Urgent(List<string> list, string item)
        {
            if (list.Contains(item))
            {
                return list;
            }
            else
            {
                list.Insert(0, item);
                return list;
            }            
        }
        static List<string> Unnecessary(List<string> list, string item)
        {
            if (list.Contains(item))
            {
                list.Remove(item);
                return list;
            }
            else
            {
                return list;
            }
        }
        static List<string> Correct(List<string> list, string oldItem, string newItem)
        {
            if (list.Contains(oldItem))
            {
                int index = list.IndexOf(oldItem);
                list.RemoveAt(index);
                list.Insert(index, newItem);
                return list;
            }
            else
            {
                return list;
            }
        }
        static List<string> Rearrange(List<string> list, string item)
        {
            if (list.Contains(item))
            {
                
                list.Remove(item);
                list.Add(item);
                return list;
            }
            else
            {
                return list;
            }
        }
    }
}
