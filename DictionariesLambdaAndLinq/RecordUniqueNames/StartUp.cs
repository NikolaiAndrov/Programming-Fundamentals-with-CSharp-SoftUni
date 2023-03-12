public class StartUp
{
    public static void Main()
    {
        var names = new HashSet<string>();

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            names.Add(Console.ReadLine());
        }

        Console.WriteLine(string.Join(Environment.NewLine, names));
    }
}