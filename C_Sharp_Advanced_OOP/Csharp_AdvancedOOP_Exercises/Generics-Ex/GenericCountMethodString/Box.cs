using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodString
{
   public class Box<T>
      where T : IComparable
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

      public void SwapListElements<T>(List<T> inputList, int firstElement, int secondElement)
      {

         var getFirstElement = inputList[firstElement];

         inputList[firstElement] = inputList[secondElement];
         inputList[secondElement] = getFirstElement;

      }

      public int CountListElements<T>(List<T> inputList, T elementToCompare)
         where T : IComparable
      {
         int count = 0;

         foreach (var item in inputList)
         {
            if (item.CompareTo(elementToCompare)>0)
            {
               count++;
            }
         }

         return count;
      }

   }

}
