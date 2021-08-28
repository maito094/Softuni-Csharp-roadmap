using System;

namespace Cinema_Tickets
{
   class Program
   {
      static void Main(string[] args)
      {
         int totalTicketsSold = 0;
         int resultTicketsSold = 0;
         int studentTypeTickets = 0;
         int standardTypeTickets = 0;
         int kidTypeTickets = 0;
         int emptySeats = 0;

         string movie = Console.ReadLine();
         string typeTicket = "";

         while (movie != "Finish")
         {
            emptySeats = int.Parse(Console.ReadLine());

            typeTicket = Console.ReadLine();

            while (typeTicket != "End")
            {

               totalTicketsSold++;

               switch (typeTicket)
               {
               case "student":
                  studentTypeTickets++;
                  break;
               case "kid":
                  kidTypeTickets++;
                  break;
               case "standard":
                  standardTypeTickets++;
                  break;

               }
               if (totalTicketsSold < emptySeats)
               {
                  typeTicket = Console.ReadLine();
               }
               else
               {
                  break;
               }
            }
            Console.WriteLine($"{movie} - {(totalTicketsSold * 100.00 / emptySeats):0.00}% full.");

            movie = Console.ReadLine();
            resultTicketsSold += totalTicketsSold;
            //studentTypeTickets = 0;
            //kidTypeTickets = 0;
            //standardTypeTickets = 0;
            totalTicketsSold = 0;

         }

         Console.WriteLine($"Total tickets: {resultTicketsSold}");
         Console.WriteLine($"{(studentTypeTickets * 100.00 / resultTicketsSold):0.00}% student tickets.");
         Console.WriteLine($"{(standardTypeTickets * 100.00 / resultTicketsSold):0.00}% standard tickets.");
         Console.WriteLine($"{(kidTypeTickets * 100.00 / resultTicketsSold):0.00}% kids tickets.");
      }
   }
}
