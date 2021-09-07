using System;

namespace _11._Math_operations
{
   class Program
   {
      static void Main(string[] args)
      {
         double firstValue = double.Parse(Console.ReadLine());
         char operater = char.Parse(Console.ReadLine());
         double secondValue = double.Parse(Console.ReadLine());
         double result = 0;

         if (operater == '/')
         {
            result = MathDivide(firstValue, secondValue);
         }
         else if (operater == '*')
         {
            result = MathMultiply(firstValue, secondValue);
         }
         else if (operater == '+')
         {
            result = MathAdd(firstValue, secondValue);
         }
         else if (operater == '-')
         {
            result = MathSubtract(firstValue, secondValue);
         }

         Console.WriteLine($"{result}");

      }

      static double MathDivide(double num1, double num2)
      {

         return num1 /= num2;
      }
      static double MathMultiply(double num1, double num2)
      {

         return num1 *= num2;
      }
      static double MathAdd(double num1, double num2)
      {

         return num1 += num2;
      }
      static double MathSubtract(double num1, double num2)
      {

         return num1 -= num2;
      }
   }
}
