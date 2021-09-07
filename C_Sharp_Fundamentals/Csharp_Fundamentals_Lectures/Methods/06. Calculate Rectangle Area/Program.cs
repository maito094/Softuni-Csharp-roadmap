using System;

namespace _06._Calculate_Rectangle_Area
{
   class Program
   {
      static void Main(string[] args)
      {
         int area = RectangleArea(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
         Console.WriteLine(area);
      }
      static int RectangleArea(int a, int b)
      {
         return a *= b;
      }
   }
}
