using System;

namespace Agency_Profit
{
   class Program
   {
      static void Main(string[] args)
      {
         string aviationCompany = Console.ReadLine();
         int numAdultTickets = int.Parse(Console.ReadLine());
         int numChildrenTickets = int.Parse(Console.ReadLine());
         double priceAdultTicket = double.Parse(Console.ReadLine());
         double taxPerTicket = double.Parse(Console.ReadLine());

         double profit = (numAdultTickets * priceAdultTicket + numChildrenTickets * (priceAdultTicket * 0.3)) + (numAdultTickets + numChildrenTickets) * taxPerTicket;
         profit = profit *1.0/ 5;
         Console.WriteLine($"The profit of your agency from {aviationCompany} tickets is {profit:f2} lv.");
      }
   }
}
