using System;

namespace GenericScale
{
   class StartUp
   {
      static void Main(string[] args)
      {
         var scale = new EqualityScale<int>(1, 1);

         Console.WriteLine(scale.AreEqual());
      }
   }
}
