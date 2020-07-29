using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Box> allBoxes = new List<Box>();
            while (input != "end")
            {
                List<string> inputProp = input.Split().ToList();
                Item currentItem = new Item(inputProp[1], decimal.Parse(inputProp[3]));
                Box currentBox = new Box(inputProp[0], currentItem, int.Parse(inputProp[2]), int.Parse(inputProp[2]) * decimal.Parse(inputProp[3]));
                allBoxes.Add(currentBox);

                input = Console.ReadLine();
            }
            allBoxes = allBoxes.OrderByDescending(o => o.PriceForABox).ToList();
            for (int i = 0; i < allBoxes.Count; i++)
            {
                Box currentBox = allBoxes[i];
                Item currentItem = allBoxes[i].Item;
                Console.WriteLine($"{currentBox.SerialNumber}");
                Console.WriteLine($"-- {currentItem.Name} - ${currentItem.Price:f2}: {currentBox.ItemQuantity}");
                Console.WriteLine($"-- ${currentBox.PriceForABox:f2}");
            }
           
        }
    }

    public class Item
    {
        public Item(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
          
        }
        
        public string Name { get; set; }
        public decimal Price { get; set; }
        
    }
    public class Box
    {
        public Box(string serialNumber, Item item, int itemQuantity, decimal priceForABox)
        {
            this.SerialNumber = serialNumber;
            this.Item = item;
            this.ItemQuantity = itemQuantity;
            this.PriceForABox = priceForABox;
        }
       
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceForABox { get; set; }
    }
}
