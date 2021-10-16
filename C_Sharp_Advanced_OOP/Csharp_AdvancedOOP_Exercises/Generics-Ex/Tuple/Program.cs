using System;

namespace Tuples
{
   class Program
   {
      static void Main(string[] args)
      {

         var personAddressInfo = Console.ReadLine().Split(" ");
         string personFullName = personAddressInfo[0] +" "+ personAddressInfo[1];
         string address = personAddressInfo[2];


         MyTuple<string, string> nameTown = new MyTuple<string, string>(personFullName, address);


         var personBeersInfo = Console.ReadLine().Split(" ");
         string nameOfPerson = personBeersInfo[0];
         int amountOfBeer = int.Parse(personBeersInfo[1]);

         MyTuple<string, int> personBeer = new MyTuple<string, int>(nameOfPerson, amountOfBeer);

         var numbersInfo = Console.ReadLine().Split(" ");
         int numberInteger = int.Parse(numbersInfo[0]);
         double numberDouble = double.Parse(numbersInfo[1]);

         MyTuple<int, double> numbers = new MyTuple<int, double>(numberInteger, numberDouble);


         Console.WriteLine(nameTown.PrintItemsInfo());
         Console.WriteLine(personBeer.PrintItemsInfo());
         Console.WriteLine(numbers.PrintItemsInfo());
      }
   }
}
