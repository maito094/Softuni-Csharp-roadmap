using System;

namespace _05._Login
{
   class Program
   {
      static void Main(string[] args)
      {
         string username = Console.ReadLine();
         string password = string.Empty;
         for (int i = username.Length - 1; i >= 0; i--)
         {

            password += username[i].ToString();
         }

         for (int i = 0; i < 4; i++)
         {

            if (password != Console.ReadLine())
            {
               if (i == 3)
               {
                  Console.WriteLine($"User {username} blocked!");
                  break;
               }
               else
               {
                  Console.WriteLine("Incorrect password. Try again.");
                  continue;

               }
            }
            else
            {
               Console.WriteLine($"User {username} logged in.");
               break;
            }

         }
      }
   }
}
