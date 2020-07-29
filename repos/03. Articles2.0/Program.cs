using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
                Article newArticle = new Article(input[0], input[1], input[2]);
                articles.Add(newArticle);
            }
            string orderBy = Console.ReadLine();
            switch (orderBy)
            {
                case "title":
                    articles = articles.OrderBy(o => o.Title).ToList();
                    break;
                case "content":
                    articles = articles.OrderBy(o => o.Content).ToList();
                    break;
                case "author":
                    articles = articles.OrderBy(o => o.Author).ToList();
                    break;
                default:
                    break;
            }
            for (int i = 0; i < articles.Count; i++)
            {
                Console.WriteLine(String.Join(Environment.NewLine, articles));
            }
        }

        public class Article
        {
            public Article(string title, string content, string author)
            {
                this.Title = title;
                this.Content = content;
                this.Author = author;
            }
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }
            public void Edit(string newContent)
            {
                this.Content = newContent;
            }
            public void ChangeAuthor(string newAuthor)
            {
                this.Author = newAuthor;
            }
            public void Rename(string newTitle)
            {
                this.Title = newTitle;
            }
          
            public override string ToString()
            {
                return $"{this.Title} - {this.Content}: {this.Author}";
            }
        }
    }
}

