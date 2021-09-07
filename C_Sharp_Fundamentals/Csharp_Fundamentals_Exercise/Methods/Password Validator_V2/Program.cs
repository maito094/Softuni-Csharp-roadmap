using System;
using System.Linq;

namespace _04._Password_Validator
{
   class Program
   {
      static void Main(string[] args)
      {
         // rule 1 = 6<lenght<10
         // rule 2 = Only Letters & Digits, No Special Symbols;
         // rule 3 = minium 2 Digits;

         if (ValidatePassword(Console.ReadLine()))
         {
            Console.WriteLine("Password is valid");
         }
      }
      static bool ValidatePassword(string password)
      {
         bool isCorrectLenght = isValidLenght(password);
         bool isDigitorLetter = IsContainingDigitOrLetter(password);
         bool isValidDigitsCounter = isAtleast2Digits(password);

         if (!isCorrectLenght)
         {
            Console.WriteLine("Password must be between 6 and 10 characters");
         }
         if (!isDigitorLetter)
         {
            Console.WriteLine("Password must consist only of letters and digits");
         }
         if (!isValidDigitsCounter)
         {
            Console.WriteLine("Password must have at least 2 digits");
         }
         if (isValidDigitsCounter && isCorrectLenght && isDigitorLetter)
         {
            return true;

         }
         return false;
      }

      private static bool isAtleast2Digits(string password)
      {
         return password.Count(char.IsDigit) >= 2;
      }

      private static bool IsContainingDigitOrLetter(string password)
      {
         return password.All(char.IsLetterOrDigit);
      }

      private static bool isValidLenght(string password)
      {
         return password.Length >= 6 && password.Length <= 10;
      }
   }
}
