using System;
using System.Linq;

namespace ListyIterator
{
   class Program
   {
      static void Main(string[] args)
      {
         string[] createCommand = Console.ReadLine().Split(" ");       
         
         var collection = new ListyIterator<string>(createCommand.Skip(1).ToArray());

         while (true)
         {
            var commandInput = Console.ReadLine();
            if (commandInput=="END")
            {
               break;
            }

            if (commandInput == "Move")
            {
               Console.WriteLine(collection.Move());

            }
            else if (commandInput == "HasNext")
            {
               Console.WriteLine( collection.HasNext());
            }
            else if (commandInput == "Print")
            {
               collection.Print();
            }
            else if (commandInput == "PrintAll")
            {
               
                  foreach (var item in collection)
                  {
                     Console.Write($"{item} ");
                  }
                  Console.WriteLine();
              
            }

         }
      }
   }
}
