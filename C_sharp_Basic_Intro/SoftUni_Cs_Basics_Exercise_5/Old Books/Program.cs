using System;

namespace Old_Books
{
   class Program
   {
      static void Main(string[] args)
      {

         string AnniesBook = Console.ReadLine();
         string book = Console.ReadLine();
         int numBooks = 0;

         while (true)
         {
            if (book != "No More Books" && book != AnniesBook)
            {
               book = Console.ReadLine();
               numBooks++;
            }
            else if (book == AnniesBook)
            {
               Console.WriteLine($"You checked {numBooks} books and found it.");
               break;
            }
            else if (book == "No More Books")
            {
               Console.WriteLine("The book you search is not here!");
               Console.WriteLine($"You checked {numBooks} books.");
               break;
            }
         }
      }
   }
}
