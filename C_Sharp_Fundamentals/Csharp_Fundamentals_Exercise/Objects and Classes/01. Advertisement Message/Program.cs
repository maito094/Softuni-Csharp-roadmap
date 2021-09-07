using System;

using System.Collections.Generic;
namespace _01._Advertisement_Message
{
   class Program
   {
      static void Main(string[] args)
      {
         int numMesseages = int.Parse(Console.ReadLine());
         RandomPhrase phrases = new RandomPhrase(new List<string> { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." });
         RandomPhrase events = new RandomPhrase(new List<string> { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" });
         RandomPhrase authors = new RandomPhrase(new List<string> { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" });
         RandomPhrase cities = new RandomPhrase(new List<string> { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" });
         for (int i = 0; i < numMesseages; i++)
         {

            Console.WriteLine($"{ phrases.GetRandomPhrase()} {events.GetRandomPhrase()} {authors.GetRandomPhrase()} - {cities.GetRandomPhrase()}");
         }
      }
   }
   class RandomPhrase
   {
      public RandomPhrase(List<string> phrases)
      {
         Phrase = phrases;
      }
      public List<String> Phrase { get; set; }

      public string GetRandomPhrase()
      {
         Random random = new Random();
         return Phrase[random.Next(Phrase.Count)];
      }
   }
}
