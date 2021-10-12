using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
   public class Box<T>
   {
      private List<T> element = new List<T>();
      public int Count => this.element.Count;

      public void Add(T element)
      {

         this.element.Add(element);

      }

      public T Remove()
      {

         T removedElement = this.element[Count - 1];
         this.element.RemoveAt(Count - 1);
         return removedElement;

      }

   }
}
