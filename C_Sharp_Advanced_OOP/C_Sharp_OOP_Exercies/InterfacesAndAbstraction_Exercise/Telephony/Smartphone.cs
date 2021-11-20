using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
   public class Smartphone : ICallable, IBrowseable
   {
      private string phoneNumber;
      private string url;
      public Smartphone(string phoneNumber)
      {
         PhoneNumber = phoneNumber;

      }
      public Smartphone(string phoneNumber, string url)
      {
         PhoneNumber = phoneNumber;
         URL = url;
      }
      public string PhoneNumber
      {
         get
         {
            return phoneNumber;
         }
         set
         {
            this.phoneNumber = value;

         }
      }

      public string URL
      {
         get
         {
            return this.url;
         }
         set
         {
            if (value.Any(char.IsDigit))
            {
               this.url = "Invalid URL!";
            }
            else
            {
               this.url = value;
            }
         }
      }
      public void Browse()
      {
         if (URL.Contains("Invalid"))
         {
            Console.WriteLine(URL);
         }
         else
         {
            Console.WriteLine($"Browsing: {this.URL}!");
         }
      }

      public void Call()
      {

         Console.WriteLine($"Calling... {this.PhoneNumber}");

      }
   }
}
