using System;
using System.Collections.Generic;
using System.Linq;


namespace _03.Articles_2._0
{
   class Program
   {
      static void Main(string[] args)
      {
         int numOfArticles = int.Parse(Console.ReadLine());
         List<Article> collectionsArticle = new List<Article>();
         for (int i = 0; i < numOfArticles; i++)
         {

            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Article article = new Article(input[0], input[1], input[2]);

            collectionsArticle.Add(article);
         }
         string criteria = Console.ReadLine();

         if (criteria == "title")
         {
            collectionsArticle = collectionsArticle.OrderBy(s => s.Title).ToList();
         }
         else if (criteria == "content")
         {
            collectionsArticle = collectionsArticle.OrderBy(s => s.Content).ToList();
         }
         else if (criteria == "author")
         {
            collectionsArticle = collectionsArticle.OrderBy(s => s.Author).ToList();
         }



         foreach (var article in collectionsArticle)
         {
            Console.WriteLine(article.ToString());

         }

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


      public override string ToString()
      {
         return $"{Title} - {Content}: {Author}";
      }

   }
}
