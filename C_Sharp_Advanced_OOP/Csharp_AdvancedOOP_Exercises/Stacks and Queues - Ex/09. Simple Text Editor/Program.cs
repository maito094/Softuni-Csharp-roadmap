using System;
using System.Collections.Generic;
using System.Text;

namespace _09._Simple_Text_Editor
{
   class Program
   {
      static void Main(string[] args)
      {

         int n = int.Parse(Console.ReadLine());
         StringBuilder text = new StringBuilder();

         Stack<string> lastText = new Stack<string>();
         for (int i = 0; i < n; i++)
         {
            string[] cmd = Console.ReadLine().Split(" ");
            string command = cmd[0];

            if (command == "1")
            {
               lastText.Push(text.ToString());

               string someString = cmd[1];
               text.Append(someString);

            }
            else if (command == "2")
            {
               lastText.Push(text.ToString());

               int count = int.Parse(cmd[1]);
               text.Remove(text.Length - count, count);
            }
            else if (command == "3")
            {
               int index = int.Parse(cmd[1]);
               Console.WriteLine(text[index - 1]);
            }
            else if (command == "4")
            {
               if (lastText.Count > 0)
               {
                  text.Clear();
                  text.Append(lastText.Pop());
               }
            }

         }

      }
   }
}