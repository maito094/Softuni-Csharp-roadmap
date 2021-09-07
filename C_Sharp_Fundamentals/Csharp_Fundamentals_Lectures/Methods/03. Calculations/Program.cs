using System;

namespace _03._Calculations
{
   class Program
   {
      static void Main(string[] args)
      {
         //(add, multiply, subtract, divide) 
         //num1
         //num2

         string operation = Console.ReadLine();
         int num1 = int.Parse(Console.ReadLine());
         int num2 = int.Parse(Console.ReadLine());

         switch (operation)
         {
            case "add":
               Additon(num1, num2);
               break;
            case "multiply":
               Multiplication(num1, num2);
               break;
            case "subtract":
               Subtraction(num1, num2);
               break;
            case "divide":
               Division(num1, num2);
               break;


            default:
               break;
         }


      }

      static void Additon(int num1, int num2)
      {
         num1 += num2;
         Console.WriteLine(num1);
      }
      static void Multiplication(int num1, int num2)
      {
         num1 *= num2;
         Console.WriteLine(num1);
      }
      static void Subtraction(int num1, int num2)
      {
         num1 -= num2;
         Console.WriteLine(num1);
      }
      static void Division(int num1, int num2)
      {
         num1 /= num2;
         Console.WriteLine(num1);
      }
   }
}
