using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            Article newArticle = new Article(input[0], input[1], input[2]);
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                List<string> command = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries).ToList();
                switch (command[0])
                {
                    case "Edit":
                        newArticle.Edit(command[1]);
                        break;
                    case "ChangeAuthor":
                        newArticle.ChangeAuthor(command[1]);
                        break;
                    case "Rename":
                        newArticle.Rename(command[1]);
                        break;
                    default:
                        break;
                }
            }
            newArticle.PrintArticle();
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
        public void PrintArticle()
        {
            Console.WriteLine($"{this.Title} - {this.Content}: {this.Author}");
        }
    }
}

