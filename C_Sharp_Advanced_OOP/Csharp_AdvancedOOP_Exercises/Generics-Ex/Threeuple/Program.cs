using System;

namespace Tuples
{
   class Program
   {
      static void Main(string[] args)
      {
         var personAddressInfo = Console.ReadLine().Split(" ");
         string personFullName = personAddressInfo[0] + " " + personAddressInfo[1];
         string address = personAddressInfo[2];
         string townName = personAddressInfo[3];


         Threeuple<string, string, string> nameTown = new Threeuple<string, string, string>(personFullName, address, townName);


         var personBeersInfo = Console.ReadLine().Split(" ");
         string nameOfPerson = personBeersInfo[0];
         int amountOfBeer = int.Parse(personBeersInfo[1]);
         bool isDrunk = (personBeersInfo[2])=="drunk"? true :false ;

         Threeuple<string, int, bool> personBeer = new Threeuple<string, int, bool>(nameOfPerson, amountOfBeer, isDrunk);

         var numbersInfo = Console.ReadLine().Split(" ");
         string nameHolder = numbersInfo[0];
         double accountBalance = double.Parse(numbersInfo[1]);
         string bankName = numbersInfo[2];

         Threeuple<string, double, string> personAccountInfo = new Threeuple<string, double, string>(nameHolder, accountBalance, bankName);


         Console.WriteLine(nameTown.PrintItemsInfo());
         Console.WriteLine(personBeer.PrintItemsInfo());
         Console.WriteLine(personAccountInfo.PrintItemsInfo());
      }
   }
}
