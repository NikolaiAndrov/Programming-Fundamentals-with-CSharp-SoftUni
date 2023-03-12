public class StartUp
{
    public static void Main()
    {
        var title = Console.ReadLine();
        var content = Console.ReadLine();

        Console.WriteLine("<h1>");
        Console.WriteLine($"    {title}");
        Console.WriteLine("</h1>");
        Console.WriteLine("<article>");
        Console.WriteLine($"    {content}");
        Console.WriteLine("</article>");

        string comment;

        while ((comment = Console.ReadLine()) != "end of comments")
        {
            Console.WriteLine("<div>");
            Console.WriteLine($"    {comment}");
            Console.WriteLine("</div>");
        }
    }
}