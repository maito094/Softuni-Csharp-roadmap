using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
   class Program
   {
      static void Main(string[] args)
      {
         int quantityOfFood = int.Parse(Console.ReadLine());
         Queue<int> orders = new Queue<int>();

         int[] foodOrderQuantity = Console.ReadLine()
                                           .Split(" ")
                                           .Select(int.Parse)
                                           .ToArray();

         int biggestOrder = int.MinValue;

         for (int i = 0; i < foodOrderQuantity.Length; i++)
         {
            orders.Enqueue(foodOrderQuantity[i]);

            if (foodOrderQuantity[i] > biggestOrder)
            {
               biggestOrder = foodOrderQuantity[i];
            }
            if (quantityOfFood >= orders.Peek())
            {
               quantityOfFood -= orders.Dequeue();
            }
         }

         Console.WriteLine(biggestOrder);

         if (orders.Count > 0)
         {
            Console.Write($"Orders left: {string.Join(" ", orders)}");
         }
         else
         {
            Console.WriteLine("Orders complete");
         }
      }
   }
}
