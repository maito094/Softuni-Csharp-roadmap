using System;
using System.Linq;

namespace _09._Palindrome_Integers
{
   class Program
   {
      static void Main(string[] args)
      {

         string number = Console.ReadLine();
         bool isPalindrome = false;

         while (number != "END")
         {
            isPalindrome = findPalindrome(number);
            Console.WriteLine(isPalindrome);

            number = Console.ReadLine();
         }
      }
      static bool findPalindrome(string number)
      {
         string revNumber = string.Join("", number.Reverse());

         if (revNumber == number)
         {
            return true;
         }

         return false;
      }
   }
}
