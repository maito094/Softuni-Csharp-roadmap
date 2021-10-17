using System;
using System.Linq;
namespace IteratorsAndComparators
{
   class IteratorsAndComparators
   {
      static void Main(string[] args)

      {
         Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
         Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
         Book bookThree = new Book("The Documents in the Case", 1930);

         Library libraryOne = new Library();
         Library libraryTwo = new Library(bookOne, bookTwo, bookThree);

         libraryTwo.SortLibrary(new BookComparator());

         foreach (var book in libraryTwo)
         {
            Console.WriteLine(book.ToString());
         }


         //libraryTwo.SortLibrary();

         //foreach (var book in libraryTwo)
         //{
         //   Console.WriteLine(book.ToString());
         //}
      }
   }

}