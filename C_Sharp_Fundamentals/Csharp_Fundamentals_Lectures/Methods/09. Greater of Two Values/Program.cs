using System;

namespace _09._Greater_of_Two_Values
{
   class Program
   {
      static void Main(string[] args)
      {
         string type = Console.ReadLine();
         string firstValue = Console.ReadLine();
         string secondValue = Console.ReadLine();

         if (type == "int")
         {
            int firstInt = int.Parse(firstValue);
            int secondInt = int.Parse(secondValue);
            Console.WriteLine(GetMax(firstInt, secondInt));
         }
         else if (type == "char")
         {
            char firstChar = char.Parse(firstValue);
            char secondChar = char.Parse(secondValue);
            char result = (char)GetMax(firstChar, secondChar);
            Console.WriteLine(result);
         }
         else if (type == "string")
         {
            string result = GetMax(firstValue, secondValue);
            Console.WriteLine(result);
         }
      }

      private static int GetMax(int firstInt, int secondInt)
      {
         if (firstInt > secondInt)
         {
            return firstInt;
         }
         return secondInt;
      }
      private static char GetMax(char firstInt, char secondInt)
      {
         if (firstInt > secondInt)
         {
            return firstInt;
         }
         return secondInt;
      }
      private static string GetMax(string firstValue, string secondValue)
      {
         if (firstValue.CompareTo(secondValue) > secondValue.CompareTo(firstValue))
         {
            return firstValue;
         }
         return secondValue;
         //firstValue.CompareTo(secondValue);
         //int firstValueSum = GetASCIISum(firstValue);
         //int secondValueSum = GetASCIISum(secondValue);

         //if (firstValueSum > secondValueSum)
         //{
         //   return firstValue.ToString();
         //}
         //return secondValue.ToString();
      }

      private static int GetASCIISum(string value)
      {
         int valueSum = 0;
         for (int i = 0; i < value.Length; i++)
         {
            valueSum += value[i];
         }

         return valueSum;
      }
   }
}
