using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
   public class ListyIterator<T> : IEnumerable<T>
   {
      private int currentIndex;
      public List<T> Collection { get; set; }
      public ListyIterator()
      {

      }
      public ListyIterator(T[] collection)
      {
         currentIndex = 0;
         Collection = new List<T>(collection);

      }

      //•	Move - should move an internal index position to the
      // next index in the list. The method should return true,
      //if it had successfully moved the index and false if there is no next index
      public bool Move()
      {

         if (HasNext())
         {
            currentIndex++;
            return true;
         }
         return false;
      }
      //•	HasNext - should return true,
      //if there is a next index and false,
      //if the index is already at the last element of the list.
      public bool HasNext() => currentIndex + 1 < Collection.Count;

      //•	Print - should print the element at the current internal index.
      //Calling Print on a collection without elements should throw an appropriate
      //exception with the message "Invalid Operation!". 
      public void Print()
      {

         if (Collection.Count == 0)
         {
            Console.WriteLine("Invalid Operation!");
            return;
         }
         else
         {
            Console.WriteLine(Collection[currentIndex]);
         }

      }



      public IEnumerator<T> GetEnumerator()
      {
         for (int i = 0; i < this.Collection.Count; i++)
            yield return this.Collection[i];
      }

      IEnumerator IEnumerable.GetEnumerator()
      {
         return this.GetEnumerator();
      }

   }


}

