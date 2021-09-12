using System;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
   class Program
   {
      static void Main(string[] args)
      {
         int numCMDs = int.Parse(Console.ReadLine());

         Dictionary<string, string> userParkingLot = new Dictionary<string, string>();

         for (int i = 0; i < numCMDs; i++)
         {
            string[] inputInfo = Console.ReadLine().Split();
            string CMD = inputInfo[0];
            string userName = inputInfo[1];

            if (CMD == "register")
            {
               string licensePlate = inputInfo[2];
               if (userParkingLot.ContainsKey(userName))
               {
                  Console.WriteLine($"ERROR: already registered with plate number {userParkingLot[userName]}");
               }
               else
               {
                  userParkingLot.Add(userName, licensePlate);
                  Console.WriteLine($"{userName} registered {licensePlate} successfully");
               }
            }
            else
            {
               if (!userParkingLot.ContainsKey(userName))
               {
                  Console.WriteLine($"ERROR: user {userName} not found");
               }
               else
               {
                  userParkingLot.Remove(userName);
                  Console.WriteLine($"{userName} unregistered successfully");
               }
            }
         }

         foreach (var (userName, licensePlate) in userParkingLot)
         {
            Console.WriteLine($"{userName} => {licensePlate}");
         }

      }
   }
}
