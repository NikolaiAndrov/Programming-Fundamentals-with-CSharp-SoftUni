public class StartUp
{
    public static void Main()
    {
        string[] articleInfo = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
        string title = articleInfo[0];
        string content = articleInfo[1];
        string author = articleInfo[2];

        Article article = new Article(title, content, author);

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] args = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);
            string command = args[0];

            if (command == "Edit")
            {
                string newContent = args[1];
                EditContent(article, newContent);
            }
            else if (command == "ChangeAuthor")
            {
                string newAuthor = args[1];
                ChangeAuthor(article, newAuthor);
            }
            else if (command == "Rename")
            {
                string newTitle = args[1];
                RenameTitle(article, newTitle);
            }
        }

        Console.WriteLine(article);
    }

    static void RenameTitle(Article article, string newTitle)
    {
        article.Title = newTitle;
    }
    static void ChangeAuthor(Article article, string newAuthor)
    {
        article.Author = newAuthor;
    }
    static void EditContent(Article article, string newContent)
    {
        article.Content = newContent;
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
        return $"{Title} - {Content}: {Author}";
    }
}