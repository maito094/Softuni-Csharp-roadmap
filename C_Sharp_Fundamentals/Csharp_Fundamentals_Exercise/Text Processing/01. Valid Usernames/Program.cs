using System;
using System.Text;


namespace _01._Valid_Usernames
{
   class Program
   {
      static void Main(string[] args)
      {

         string[] userNames = Console.ReadLine().Split(", ");

         StringBuilder validUsers = new StringBuilder();

         bool isSpecialChar = false;
         foreach (var user in userNames)
         {
            isSpecialChar = false;
            if (user.Length > 3 && user.Length < 16)
            {
               for (int i = 0; i < user.Length; i++)
               {
                  if (!char.IsLetterOrDigit(user[i]) && (user[i] != '-' && user[i] != '_'))
                  {
                     isSpecialChar = true;
                     break;
                  }
               }
               if (isSpecialChar)
               {
                  continue;
               }

               validUsers.AppendLine(user);
            }
         }
         Console.WriteLine(validUsers);
      }
   }
}
