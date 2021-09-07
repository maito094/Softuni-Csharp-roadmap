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


         ValidatePassword(Console.ReadLine());
      }
      static void ValidatePassword(string password)
      {
         bool isNotCorrectLenght = false;
         bool isNotDigitorLetter = false;
         bool isNotValidDigitsCounter = false;
         int digitCounter = 0;

         if (password.Length < 6 || password.Length > 9)
         {
            isNotCorrectLenght = true;
         }


         for (int i = 0; i < password.Length; i++)
         {
            if (!char.IsLetterOrDigit(password[i]))
            {
               isNotDigitorLetter = true;
            }
            if (char.IsDigit(password[i]))
            {
               digitCounter++;
            }

         }

         if (digitCounter < 2)
         {
            isNotValidDigitsCounter = true;
         }


         if (isNotCorrectLenght)
         {
            Console.WriteLine("Password must be between 6 and 10 characters");
         }
         if (isNotDigitorLetter)
         {
            Console.WriteLine("Password must consist only of letters and digits");
         }
         if (isNotValidDigitsCounter)
         {
            Console.WriteLine("Password must have at least 2 digits");
         }
         if (!isNotValidDigitsCounter && !isNotCorrectLenght && !isNotDigitorLetter)
         {
            Console.WriteLine("Password is valid");
         }
      }
   }
}
