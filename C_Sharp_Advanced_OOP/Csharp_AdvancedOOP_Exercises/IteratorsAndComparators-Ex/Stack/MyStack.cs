using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
   class MyStack<T> : IEnumerable<T>
   {
      private readonly List<T> elements;

      public MyStack(params T[] elements)
      {
         this.elements = new List<T>(elements);

      }

      public void Push(params T[] elements)
      {
         foreach (var item in elements)
         {
            this.elements.Add(item);

         }

      }
      public T Pop()
      {

         if (this.elements.Count == 0)
         {
            Console.WriteLine("No elements");

            return default;
         }

         T popElement = elements[elements.Count - 1];
         this.elements.RemoveAt(elements.Count - 1);

         return popElement;
      }
      public IEnumerator<T> GetEnumerator()
      {
         for (int i = elements.Count - 1; i >= 0; i--)
            yield return elements[i];
      }

      IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
   }
}
