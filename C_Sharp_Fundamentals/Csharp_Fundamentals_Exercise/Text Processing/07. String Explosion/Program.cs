using System;
using System.Text;

namespace _07._String_Explosion
{
   class Program
   {
      static void Main(string[] args)
      {
         string input = Console.ReadLine();
         StringBuilder sb = new StringBuilder(input);
         int powerPunch = 0;
         for (int i = 0; i < sb.Length; i++)
         {
            if (powerPunch > 0 && sb[i] != '>')
            {
               sb.Remove(i, 1);
               powerPunch--;
               i--;
            }
            else if (sb[i] == '>')
            {
               powerPunch += int.Parse(sb[i + 1].ToString());
               sb.Remove(i + 1, 1);
               powerPunch--;
            }


         }


         Console.WriteLine(sb);
      }
   }
}
