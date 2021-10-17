using System;
using System.Linq;

namespace Stack
{
   class Program
   {
      static void Main(string[] args)
      {
         string cmd = string.Empty;

         MyStack<int> myStack = new MyStack<int>();

         while ((cmd = Console.ReadLine()) != "END")
         {

            var elements = cmd.Split(" ",StringSplitOptions.RemoveEmptyEntries)
                              .Skip(1)
                              .Select(x => x.Replace(",", ""))
                              .Select(int.Parse)
                              .ToArray();

            if (cmd.Contains("Push"))
            {
               myStack.Push(elements);
            }
            else if (cmd.Contains("Pop"))
            {
               Console.WriteLine(myStack.Pop());
            }
         }

         foreach (var item in myStack)
         {
            Console.WriteLine(item);
         }

         foreach (var item in myStack)
         {
            Console.WriteLine(item);
         }

      }
   }
}
