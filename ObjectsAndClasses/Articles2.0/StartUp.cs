﻿public class StartUp
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<Article> articles = new List<Article>();

        for (int i = 0; i < n; i++)
        {
            string[] articleInfo = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string title = articleInfo[0];
            string content = articleInfo[1];
            string author = articleInfo[2];

            Article article = new Article(title, content, author);
            articles.Add(article);
        }

        foreach (Article article in articles)
        {
            Console.WriteLine(article);
        }
    }
}

public class Article
{
    public Article(string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }

    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }

    public override string ToString()
    {
        return $"{Title} - {Content}: {Author} ";
    }
}