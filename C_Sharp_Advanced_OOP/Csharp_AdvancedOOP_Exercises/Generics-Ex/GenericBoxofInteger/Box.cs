using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxofInteger
{
   public class Box<T>
   {

      public List<T> Item { get; set; }

      public Box()
      {
         Item = new List<T>();
      }

      public override string ToString()
      {
         StringBuilder stringBuilder = new StringBuilder();

         foreach (var item in Item)
         {
            stringBuilder.AppendLine($"{typeof(T)}: {item}");

         }
            return stringBuilder.ToString().TrimEnd();

      }

   }

}
