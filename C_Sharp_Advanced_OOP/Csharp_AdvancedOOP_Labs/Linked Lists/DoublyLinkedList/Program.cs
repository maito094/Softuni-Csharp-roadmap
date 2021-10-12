using System;

namespace DoublyLinkedList
{




   public class Program

   {
      static void Main(string[] args)
      {
         var list = new DoublyLinkedList();
         list.AddFirst(3);
         // 3
         Console.WriteLine(string.Join("-", list.ToArray()));

         list.AddFirst(2);
         // 2-3                         
         Console.WriteLine(string.Join("-", list.ToArray()));

         list.AddFirst(1);
         // 1-2-3                      
         Console.WriteLine(string.Join("-", list.ToArray()));

         list.AddLast(4);
         // 1-2-3-4                     
         Console.WriteLine(string.Join("-", list.ToArray()));

         list.AddFirst(0);
         // 0-1-2-3-4                   
         Console.WriteLine(string.Join("-", list.ToArray()));

         list.AddLast(100);
         // 0-1-2-3-4-100               
         Console.WriteLine(string.Join("-", list.ToArray()));

         list.RemoveFirst();
         // 1-2-3-4-100                
         Console.WriteLine(string.Join("-", list.ToArray()));

         list.RemoveLast();
         // 1-2-3-4                     
         Console.WriteLine(string.Join("-", list.ToArray()));

         list.AddLast(5);
         //1-2-3-4-5
         Console.WriteLine(list.Count);
         Console.WriteLine(string.Join(", ", list.ToArray()));

         list.ForEach(PrintToConsole);
         //list.ForEach(x => Console.WriteLine(x));
         //list.ForEach(Console.WriteLine()); it takes void method action
      }
      static void PrintToConsole(int i) => Console.WriteLine(i);
   }
}
