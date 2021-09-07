using System;
using System.Collections.Generic;
using System.Linq;


namespace _02.Articles
{
   class Program
   {
      static void Main(string[] args)
      {
         string[] cmd = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
         Article article = new Article(cmd[0], cmd[1], cmd[2]);

         int numCMD = int.Parse(Console.ReadLine());
         for (int i = 0; i < numCMD; i++)
         {
            string[] CMD = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);

            if (CMD[0] == "Edit")
            {
               article.Edit(CMD[1]);
            }
            else if (CMD[0] == "ChangeAuthor")
            {
               article.ChangeAuthor(CMD[1]);
            }
            else if (CMD[0] == "Rename")
            {
               article.Rename(CMD[1]);
            }
         }
         //List<int> random = Console.ReadLine()
         //                 .Split()
         //                 .Select(int.Parse)
         //                 .ToList();
         Console.WriteLine(article.ToString());
      }
   }
   class Article
   {
      public string Title { get; set; }
      public string Content { get; set; }
      public string Author { get; set; }


      public Article(string title, string content, string author)
      {
         Title = title;
         Content = content;
         Author = author;
      }

      public void Edit(string content)
      {
         Content = content;
      }
      public void ChangeAuthor(string author)
      {
         Author = author;
      }
      public void Rename(string title)
      {
         Title = title;
      }
      public override string ToString()
      {
         return $"{Title} - {Content}: {Author}";
      }

   }
}
