using System;
using System.Collections.Generic;
using System.Linq;


namespace _06.Store_Boxes
{
   class Program
   {
      static void Main(string[] args)
      {

         //{Serial Number} {Item Name} {Item Quantity} {itemPrice}
         string[] input = Console.ReadLine().Split();

         List<Box> boxes = new List<Box>();

         while (input[0] != "end")
         {
            Item currItem = new Item(input[1], decimal.Parse(input[3]));

            Box currBox = new Box(input[0], currItem, int.Parse(input[2]));

            boxes.Add(currBox);

            input = Console.ReadLine().Split();
         }

         List<Box> sortedDescendingBoxes = boxes;

         sortedDescendingBoxes = boxes.OrderByDescending(s => s.PriceForABox).ToList();


         foreach (var box in sortedDescendingBoxes)
         {
            Console.WriteLine(box.SerialNumber);
            Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
            Console.WriteLine($"-- ${box.PriceForABox:F2}");

         }

      }
   }

   class Item
   {
      public string Name { get; set; }
      public decimal Price { get; set; }

      public Item(string name, decimal price)
      {
         Name = name;
         Price = price;
      }
   }

   class Box
   {
      public string SerialNumber { get; set; }
      public Item Item { get; set; }
      public int ItemQuantity { get; set; }
      public decimal PriceForABox { get; set; }

      public Box(string serialNumber, Item item, int itemQuantity)
      {
         SerialNumber = serialNumber;
         Item = item;
         ItemQuantity = itemQuantity;
         PriceForABox = item.Price * ItemQuantity;
      }

      public Box()
      {
      }
   }


}
