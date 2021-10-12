using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedList
{
   public class DoublyLinkedList
   {
      private LinkedListItem first = null;
      private LinkedListItem last = null;

      public int Count
      {
         get
         {
            var count = 0;
            var current = first;
            while (current != null)
            {
               count++;
               current = current.Next;
            }
            
            return count;
         }
      }

      //– adds an element at the beginning of the collection
      public void AddFirst(int element)
      {
         var newItem = new LinkedListItem(element);
         if (first == null)
         {
            first = newItem;
            last = newItem;
         }
         else
         {
            newItem.Next = first;
            first.Previous = newItem;
            first = newItem;
         }

      }
      //– adds an element at the end of the collection
      public void AddLast(int element)
      {
         var newItem = new LinkedListItem(element);
         if (last == null)
         {
            first = newItem;
            last = newItem;
         }
         else
         {
            last.Next = newItem;
            newItem.Previous = last;
            last = newItem;
         }

      }
      //– removes the element at the beginning of the collection
      public int RemoveFirst()
      {
         if (first == null)
         {
            //TODO : Exceptions
            // Forn now Do nothing
            return 0;
         }
         var currentFirstValue = first.Value;
         if (first == last) //1 item
         {
            first = null;
            last = null;
         }
         else  // more than 1 item
         {
            var newFirst = first.Next;
            newFirst.Previous = null;
            first = newFirst;
         }

         return currentFirstValue;
      }
      //– removes the element at the end of the collection
      public int RemoveLast()
      {
         if (last == null)
         {
            //TODO : Exceptions
            // Forn now Do nothing
            return 0;
         }
         var currentLastValue = last.Value;
         if (first == last) //1 item
         {
            first = null;
            last = null;
         }
         else  // more than 1 item
         {
            var newLast = last.Previous;
            newLast.Next = null;
            last = newLast;
         }

         return currentLastValue;
      }
      //– goes through the collection and executes a given action
      public void ForEach(Action<int> action)
      {
         var current = first;
         while (current != null)
         {
            action(current.Value);
            current = current.Next;
         }
      }
      // – returns the collection as an array
      public int[] ToArray()
      {
         var array = new int[Count];

         var current = first;
         var i = 0;
         while (current != null)
         {
            array[i] = current.Value;
            current = current.Next;
            i++;
         }
         return array;
      }

   }


}
