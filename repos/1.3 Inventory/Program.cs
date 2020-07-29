using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._3_Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfItems = Console.ReadLine().Split(new char[] {',',' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = Console.ReadLine();
            while (input != "Craft!")
            {
                List<string> command = input.Split(new char[] {' ','-',':'}, StringSplitOptions.RemoveEmptyEntries).ToList();
                switch (command[0])
                {
                    case "Collect":
                        CollectItem(listOfItems, command[1]);
                        break;
                    case "Drop":
                        DropItem(listOfItems, command[1]);
                        break;
                    case "Combine":
                        CombineItems(listOfItems, command[2], command[3]);
                        break;
                    case "Renew":
                        RenewItem(listOfItems, command[1]);
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(", ", listOfItems));
        }
        static List<string> CollectItem(List<string> list, string item)
        {
            if (list.Contains(item))
            {
                return list;
            }
            else
            {
                list.Add(item);
                return list;
            }            
        }
        static List<string> DropItem(List<string> list, string item)
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
        static List<string> CombineItems(List<string> list, string oldItem, string newItem)
        {
            if (list.Contains(oldItem))
            {
                int index = list.IndexOf(oldItem);
                list.Insert(index+1,newItem);
                return list;
            }
            else
            {
                return list;
            }
        }
        static List<string> RenewItem(List<string> list, string item)
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
