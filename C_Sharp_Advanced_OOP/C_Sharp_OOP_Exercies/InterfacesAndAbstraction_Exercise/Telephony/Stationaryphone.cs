using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
   public class StationaryPhone : ICallable
   {
      private string phoneNumber;
      public StationaryPhone(string phoneNumber)
      {
         PhoneNumber = phoneNumber;
      }

      public string PhoneNumber
      {
         get
         {
            return this.phoneNumber;
         }
         set
         {
         
               this.phoneNumber = value;
            

         }
      }
      public void Call()
      {
     
            Console.WriteLine($"Dialing... {PhoneNumber}");
         

      }
   }
}
