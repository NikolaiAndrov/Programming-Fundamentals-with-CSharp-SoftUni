public class StartUp
{
    public static void Main()
    {
        var path = Console.ReadLine()
            .Split('\\')
            .Last()
            .Split('.')
            .ToList();

        var extension = path.Last();
        path.Remove(extension);
        var file = string.Join('.', path);

        Console.WriteLine($"File name: {file}");
        Console.WriteLine($"File extension: {extension}");
    }
}