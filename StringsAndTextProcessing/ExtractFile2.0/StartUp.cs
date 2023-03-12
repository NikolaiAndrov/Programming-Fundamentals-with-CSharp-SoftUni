public class StartUp
{
    public static void Main()
    {
        var path = Console.ReadLine()
            .Split('\\')
            .Last();

        var index = path.LastIndexOf('.');
        var file = path.Substring(0, index);
        var extension = path.Substring(index + 1);

        Console.WriteLine($"File name: {file}");
        Console.WriteLine($"File extension: {extension}");
    }
}